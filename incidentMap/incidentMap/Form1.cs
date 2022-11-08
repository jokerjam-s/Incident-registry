using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.ToolTips;

namespace incidentMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // получить опции запуска
        private void getOptions()
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                CommandText = "getOptions",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Connection.Open();
            SqlDataReader drOpt = cmd.ExecuteReader();

            if (drOpt.HasRows)
            {
                drOpt.Read();
            }
            
            OptionsApp.department = drOpt.GetString(0);
            OptionsApp.place = drOpt.GetString(1);
            OptionsApp.beginX = drOpt.GetDecimal(2);
            OptionsApp.beginY = drOpt.GetDecimal(3);
            OptionsApp.UsedMap = drOpt.GetInt32(4);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "regionDataSet.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this.regionDataSet.region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindDataSet.kind". При необходимости она может быть перемещена или удалена.
            this.kindTableAdapter.Fill(this.kindDataSet.kind);
            // http://csharpcoderr.com/2014/08/windows-form-gmapnet.html

            getOptions();   // прочитать настройки программы

            gmMap.CanDragMap = true;
            gmMap.DragButton = MouseButtons.Left;

            gmMap.GrayScaleMode = true;

            gmMap.MarkersEnabled = true;

            gmMap.NegativeMode = false;
            gmMap.PolygonsEnabled = true;
            gmMap.RoutesEnabled = true;

            gmMap.MaxZoom = 18;
            gmMap.MinZoom = 2;
            gmMap.Zoom = 15;

            gmMap.MouseWheelZoomEnabled = true;

            gmMap.Bearing = 0;


            gmMap.ShowTileGridLines = false;

            if(OptionsApp.UsedMap == 0)
                gmMap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            else
                gmMap.MapProvider = GMap.NET.MapProviders.GMapProviders.YandexMap;

            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerOnly;

            // настройки прокси
            GMap.NET.MapProviders.GMapProvider.WebProxy =
                System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
                System.Net.CredentialCache.DefaultCredentials;

            reposMap();

            dtDate.Value = DateTime.Now.Date;
        }

        // перепозиционирование карты
        private void reposMap()
        {
            gmMap.Position = new PointLatLng((double)OptionsApp.beginX, (double)OptionsApp.beginY);
            showCoord();
        }

        // отобразить координаты
        private void showCoord()
        {
            txLatNow.Text = gmMap.Position.Lat.ToString();
            txLngNow.Text = gmMap.Position.Lng.ToString();
        }



        private void mExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mKind_Click(object sender, EventArgs e)
        {
            KindForm frm = new KindForm();

            frm.Show();
        }

        private void mAbout_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();

            frm.ShowDialog(this);
        }

        private void mOptions_Click(object sender, EventArgs e)
        {
            OptionsForm frm = new OptionsForm();

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                reposMap();
        }

        private void gmMap_OnMapDrag()
        {
            showCoord();
        }

        private void gmMap_OnMapZoomChanged()
        {
            showCoord();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //tlPanel.
        }

        private void mForm_Click(object sender, EventArgs e)
        {
            HardsForm frm = new HardsForm();

            frm.Show();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Установить текущие координаты для загрузки по умолчанию?", 
                Text, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                OptionsApp.beginX = (decimal)gmMap.Position.Lat;
                OptionsApp.beginY = (decimal)gmMap.Position.Lng;


                SqlCommand cmd = new SqlCommand()
                {
                    Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                    CommandText = "setOptions",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@department", OptionsApp.department);
                cmd.Parameters.AddWithValue("@place", OptionsApp.place);
                cmd.Parameters.AddWithValue("@beginX", OptionsApp.beginX);
                cmd.Parameters.AddWithValue("@beginY", OptionsApp.beginY);
                cmd.Parameters.AddWithValue("@usedMap", OptionsApp.UsedMap);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(OptionsApp.id_us == 0)
            {
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("Завершить работу?", this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void mAdmin_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();

            frm.Show();
        }

        private void mRegion_Click(object sender, EventArgs e)
        {
            RegionForm frm = new RegionForm();

            frm.Show();
        }

        private void mNew_Click(object sender, EventArgs e)
        {
            IncidentNewForm frm = new IncidentNewForm();

            frm.ShowDialog(this);
            if (frm.DialogResult == DialogResult.OK)
                FillData();
        }

        private void FillData()
        {
            int mode = (rbActionNow.Checked) ? 1 : ((rbAllOpen.Checked) ? 2 : 3);
            int id_kn = (chKind.Checked) ? (int)cbKind.SelectedValue : 0;
            int id_rg = (chRegion.Checked) ? (int)cbRegion.SelectedValue : 0;

            getIncViewTableAdapter.Fill(getIncDataSet.getIncView, dtDate.Value.Date, mode, id_kn, id_rg);

            gmMap.Overlays.Clear();
            GMapOverlay gOver = new GMapOverlay("incidentOverlay");

            foreach (DataRow item in getIncDataSet.getIncView.Rows)
            {
                GMapMarkerImage gmMark;
                double pX = Convert.ToDouble(item["pointX"]);
                double pY = Convert.ToDouble(item["pointY"]);

                int imgNo = ((bool)item["ncClosed"] == false) ? (Convert.ToInt32(item["hdImage"]) - 1) : 3;

                gOver.Markers.Add(new GMapMarkerImage(new PointLatLng(pX, pY), imageList1.Images[imgNo]));
                gOver.Markers.Last().ToolTipText = "Прот. №" + item["id_inc"].ToString() + " - " + item["ncDate"].ToString(); ;
                
            }

            gmMap.Overlays.Add(gOver);
            gmMap.ReloadMap();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            FillData();
            grIncident.Text = $"Проишествия - Всего:{getIncDataSet.getIncView.Count}";
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (getIncViewBindingSource.Count == 0) return;

            int id_inc = (int)((DataRowView)getIncViewBindingSource.Current).Row["id_inc"];

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                CommandText = "incidentDel",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@id_inc", id_inc);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            FillData();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (getIncViewBindingSource.Count == 0) return;

            CloseIncidentForm frm = new CloseIncidentForm();

            frm.id_inc = (int)((DataRowView)getIncViewBindingSource.Current).Row["id_inc"];

            frm.ShowDialog(this);
            if (frm.DialogResult == DialogResult.OK)
                FillData();

        }

        private void gmMap_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                IncidentNewForm frm = new IncidentNewForm();

                frm.pointX = (decimal)gmMap.FromLocalToLatLng(e.X, e.Y).Lat;
                frm.pointY = (decimal)gmMap.FromLocalToLatLng(e.X, e.Y).Lng;

                frm.ShowDialog(this);
                if (frm.DialogResult == DialogResult.OK)
                {
                    FillData();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            IncidentNewForm frm = new IncidentNewForm();

            frm.pointX = (decimal)gmMap.Position.Lat;
            frm.pointY = (decimal)gmMap.Position.Lng;

            frm.ShowDialog(this);
            if(frm.DialogResult == DialogResult.OK)
            {
                FillData();
            }
                
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();

            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                    CommandText = "getUser",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@login", frm.login);
                cmd.Parameters.AddWithValue("@pass", frm.passw);

                cmd.Connection.Open();
                SqlDataReader rdUser = cmd.ExecuteReader();

                if (rdUser.HasRows)
                {
                    rdUser.Read();

                    OptionsApp.id_us = rdUser.GetInt32(0);
                    OptionsApp.id_role = (rdUser.GetInt32(1) == 1) ? userRoles.Admin : userRoles.Operator;
                    OptionsApp.usFio = rdUser.GetString(2);

                    if(OptionsApp.id_role != userRoles.Admin)
                    {
                        mAdmin_hideAdmin.Visible =
                            mHideAdmin1.Visible =
                            mHideAdmin2.Visible =
                            mOptions_hideAdmin.Visible =
                            mSpravka_hideAdmin.Visible =
                            tbSpravka_hideAdmin.Visible = 
                            tbOptions__hideAdmin.Visible = false;
                    }

                }

                cmd.Connection.Close();

                if (OptionsApp.id_us == 0)
                {
                    MessageBox.Show("Неверный логин/пароль!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void chKind_CheckedChanged(object sender, EventArgs e)
        {
            cbKind.Enabled = chKind.Checked;
        }

        private void chRegion_CheckedChanged(object sender, EventArgs e)
        {
            cbRegion.Enabled = chRegion.Checked;
        }
    }


    class GMapMarkerImage : GMapMarker
    {
        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                if (image != null)
                {
                    this.Size =
                        new Size(image.Width,
                            image.Height);
                }
            }
        }

        public GMapMarkerImage(
            GMap.NET.PointLatLng p,
            Image image)
            : base(p)
        {
            Size =
                new System.Drawing.Size(
                    image.Width,
                    image.Height);
            Offset =
                new System.Drawing.Point(
                    -Size.Width / 2,
                    -Size.Height / 2);
            this.image = image;
        }

        public override void OnRender(Graphics g)
        {
            if (image != null)
            {

                Rectangle rect =
                    new Rectangle(LocalPosition.X,
                                  LocalPosition.Y,
                                  Size.Width,
                                  Size.Height);
                g.DrawImage(image, rect);
            }
        }
    }
}

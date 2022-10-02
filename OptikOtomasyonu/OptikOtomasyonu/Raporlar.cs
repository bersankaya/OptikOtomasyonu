﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptikOtomasyonu
{
    static class Raporlar
    {
        public static string Baslik { get; set; }
        public static string TarihBaslangic { get; set; }
        public static string TarihBitis { get; set; }
        public static string SatisNakit { get; set; }
        public static string SatisKart { get; set; }
        public static string IadeNakit { get; set; }
        public static string IadeKart { get; set; }
        public static string GelirNakit { get; set; }
        public static string GelirKart { get; set; }
        public static string GiderNakit { get; set; }
        public static string GiderKart { get; set; }
        public static string KdvToplam { get; set; }
        public static string KartKomisyon { get; set; }

        public static void RaporSayfsiRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<TBLISLEMOZET> list = new List<TBLISLEMOZET>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new TBLISLEMOZET
                {
                    IslemNo = Convert.ToInt32(dgv.Rows[i].Cells["IslemNo"].Value.ToString()),
                    Iade = Convert.ToBoolean(dgv.Rows[i].Cells["Iade"].Value),
                    OdemeSekli = dgv.Rows[i].Cells["OdemeSekli"].Value.ToString(),
                    Nakit = islemler.decimalyap(dgv.Rows[i].Cells["Nakit"].Value.ToString()),
                    Kart = islemler.decimalyap(dgv.Rows[i].Cells["Kart"].Value.ToString()),
                    Gelir = Convert.ToBoolean(dgv.Rows[i].Cells["Gelir"].Value.ToString()),
                    Gider = Convert.ToBoolean(dgv.Rows[i].Cells["Gider"].Value.ToString()),
                    AlisFiyatToplam = Convert.ToDecimal(dgv.Rows[i].Cells["AlisFiyatToplam"].Value.ToString()),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString()),
                    Kullanici = dgv.Rows[i].Cells["Kullanici"].Value.ToString()

                });
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DsGenelRapor";
            rs.Value = list;
            FrmRaporGoster fr = new FrmRaporGoster();
            fr.reportViewer1.LocalReport.DataSources.Clear();
            fr.reportViewer1.LocalReport.DataSources.Add(rs);
            fr.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpGenelRapor.rdlc";
            ReportParameter[] prm = new ReportParameter[13];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1]= new ReportParameter("TarihBaslangic",TarihBaslangic);
            prm[2]= new ReportParameter("TarihBitis",TarihBitis);
            prm[3]= new ReportParameter("SatisNakit",SatisNakit);
            prm[4]= new ReportParameter("SatisKart",SatisKart);
            prm[5]= new ReportParameter("IadeNakit",IadeNakit);
            prm[6]= new ReportParameter("IadeKart",IadeKart);
            prm[7]= new ReportParameter("GelirNakit",GelirNakit);
            prm[8]= new ReportParameter("GelirKart",GelirKart);
            prm[9]= new ReportParameter("GiderNakit",GiderNakit);
            prm[10]= new ReportParameter("GiderKart",GiderKart);
            prm[11]= new ReportParameter("KdvToplam",KdvToplam);
            prm[12]= new ReportParameter("KartKomisyon",KartKomisyon);
            fr.reportViewer1.LocalReport.SetParameters(prm);
            //fr.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            fr.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            fr.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        public static void StokRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<TBLURUN> list = new List<TBLURUN>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new TBLURUN
                {
                    Barkod = dgv.Rows[i].Cells["Barkod"].Value.ToString(),
                    UrunAd = dgv.Rows[i].Cells["UrunAd"].Value.ToString(),
                    UrunGrup=dgv.Rows[i].Cells["UrunGrup"].Value.ToString(),
                    Birim = dgv.Rows[i].Cells["Birim"].Value.ToString(),
                    SatisFiyat=islemler.decimalyap(dgv.Rows[i].Cells["SatisFiyat"].Value.ToString()),
                    Miktar=islemler.decimalyap(dgv.Rows[i].Cells["Miktar"].Value.ToString()),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),
                });
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokUrun";
            rs.Value = list;
            FrmRaporGoster fr = new FrmRaporGoster();
            fr.reportViewer1.LocalReport.DataSources.Clear();
            fr.reportViewer1.LocalReport.DataSources.Add(rs);
            fr.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokUrun.rdlc";
            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            fr.reportViewer1.LocalReport.SetParameters(prm);
            fr.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            fr.reportViewer1.ZoomMode = ZoomMode.PageWidth;

            fr.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        public static void StokIzlemeRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<TBLSTOKHAREKET> list = new List<TBLSTOKHAREKET>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new TBLSTOKHAREKET
                {
                    Barkod = dgv.Rows[i].Cells["Barkod"].Value.ToString(),
                    UrunAd = dgv.Rows[i].Cells["UrunAd"].Value.ToString(),
                    UrunGrup = dgv.Rows[i].Cells["UrunGrup"].Value.ToString(),
                    Birim = dgv.Rows[i].Cells["Birim"].Value.ToString(),
                    Miktar = islemler.decimalyap(dgv.Rows[i].Cells["Miktar"].Value.ToString()),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString()),
                    Kullanici=dgv.Rows[i].Cells["Kullanici"].Value.ToString()
                }) ;
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokIzleme";
            rs.Value = list;
            FrmRaporGoster fr = new FrmRaporGoster();
            fr.reportViewer1.LocalReport.DataSources.Clear();
            fr.reportViewer1.LocalReport.DataSources.Add(rs);
            fr.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokIzleme.rdlc";
            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            fr.reportViewer1.LocalReport.SetParameters(prm);
            fr.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            fr.reportViewer1.ZoomMode = ZoomMode.PageWidth;

            fr.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

    }
}
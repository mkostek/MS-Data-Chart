/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Asus
 * Tarih: 13.12.2019
 * Zaman: 13:47
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Tools.Office.Project.Excel;
namespace iş_zekası
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		

		void CheckedListBox1ItemCheck(object sender, ItemCheckEventArgs e)//çek edilen kolonları grid e ekler
		{

			if(e.CurrentValue.ToString()=="Unchecked")//çek edilen alanları dataview de göstermek için
				dataGridView1.Columns.Add(checkedListBox1.Items[e.Index].ToString(),checkedListBox1.Items[e.Index].ToString());
			else//çek edilmediyse
				dataGridView1.Columns.Remove(checkedListBox1.Items[e.Index].ToString());
			//kaldır
			
		}
		
		
		public void fnctn() {

			chartBirinciDerece.ChartAreas["ChartArea1"].AxisX.Interval=1;//her bir x değeri bir çizgiye denk gelecek
			string[] sozce={"220","160","102","kum","nakliye","dolgu","blokaj","toprak","stabilize","mıcır","kırıcılı 220","kırıcılı 160"};
			//bu sozcelere göre chart ın apsisi belli olacaktır
			foreach(var series in chartikinciDerece.Series)
				series.Points.Clear();//serinin bütün noktalarını sil
			foreach(var series in chartBirinciDerece.Series)
				series.Points.Clear();//serinin bütün noktalarını sil
			double[] deger=new double[12];//belirtilen zaman zarfında yapılan çalışmalar bu 12 değişkende tutlacak
			double[] ucret=new double[12];
			dataGridView1.Rows.Clear();//datagrid i süpür
			OleDbConnection Baglanti;//yeni bağlantı olustur
			OleDbCommand myCommand = new OleDbCommand();//yeni komut yap
			
			string sql ="";
			Baglanti = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='big data.xls';Extended Properties=Excel 8.0;");
			Baglanti.Open();//baglan
			myCommand.Connection = Baglanti;//komutu baglantıya ata
			sql = "Select " ;//sql e basla
			int i=0;
			foreach(object itemChecked in checkedListBox1.CheckedItems) {
				if(i==0) sql+=" "+itemChecked.ToString();
				else sql+=","+itemChecked.ToString();
				i++;
			}//çek edilen alanları sql ifadesinden al
			sql+=" from [Sayfa1$] ";
			int birinci=dateTimePicker1.Value.Month*30+dateTimePicker1.Value.Day+dateTimePicker1.Value.Year*365;
			int ikinci=dateTimePicker2.Value.Month*30+dateTimePicker2.Value.Day+dateTimePicker2.Value.Year*365;//excel de toplam gün sayısına göre hesapladım yoksa olmuyor
			//baslangıç ve bitis zamanı dilimini belirle
			sql+=" where YEAR(tarih)*365+MONTH(tarih)*30+DAY(tarih) between "+birinci+" and  "+ikinci+" order by YEAR(tarih)*365+MONTH(tarih)*30+DAY(tarih)";
			//bu zaman dilimi içindeki kayıtları gelsin
			
			myCommand.CommandText = sql;//sql execute edilecek
			OleDbDataReader dr = myCommand.ExecuteReader();

			/*datareader içindeki verileri okuma*/
			string[] s=new string[i];
			///datagrid e girilecek satırda kaç tane alan olacak dersen i tane
			int m=0,n=0,u=0;//bu değişkenler malzeme yi ve miktarının kaçıncı sırada olduğunu bilmemiz için
			int k=0;
			while(dr.Read())//dr yi dongule
			{
				k=0;
				foreach(object itemChecked in checkedListBox1.CheckedItems)//for ile checklistbox1 in itemlerini dolaş
				{
					s[k]=dr[itemChecked.ToString()].ToString();//başlık değerlerine göre değerlerini al
					switch(itemChecked.ToString())
					{
						case "malzemeAd"://eğerki dödürülen alan malzemead sa bu sıra m ye kaydet
							m=k;break;
						case "miktar"://yok eğer bu miktar alanıysa n ye
							n=k;break;
						case "ucret"://ucretse ucreti al
							u=k;break;
							default:break;
					}
					
					k++;//sırayla devam et
				}
				for(int l=0;l< sozce.Length;l++){//x aspsislerine göre toplam çalışma miktarlarını ve toplam ucretlerini alıyoruz
					if(sozce[l]==s[m])
					{
						deger[l]+=Convert.ToDouble(s[n]);//miktarları
						ucret[l]+=Convert.ToDouble(s[u]);//ucretleri
					}
				}
				
				dataGridView1.Rows.Add(s);//kaydet
			}
			int total=0;
			for(int y=0;y<12;y++)//ve son olarak charta bu değerleri göster
			{
				chartBirinciDerece.Series[0].Points.AddXY(sozce[y],deger[y]);//miktarları göster
				chartikinciDerece.Series[0].Points.AddXY(sozce[y],ucret[y]);//ücretleri göster
				total+=(int)ucret[y];
			}
			label1.Text="Ciro:"+total.ToString()+" TL";//toplam ciroyu göster
			Baglanti.Close();
		}

		
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			fnctn();//değişirse değiştir
		}
		
		void DateTimePicker2ValueChanged(object sender, EventArgs e)
		{
			fnctn();//değişirse değiştir
		}
		
		void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			fnctn();//index değişirse 
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			for (int j = 0; j < checkedListBox1.Items.Count; j++)
			{
				checkedListBox1.SetItemChecked(j, true);//başlangıç çeklistin bütün itemleri çek edili olsun
				fnctn();
			}
		}
	}
}

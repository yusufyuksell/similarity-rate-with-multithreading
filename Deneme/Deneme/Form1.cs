using IronXL;
using Microsoft.Data.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {   
        
        List<Data> products = new List<Data>();
        
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls= false;

            var reader = new StreamReader(@"C:\Users\BilenPC\Desktop\final.csv");
            int dataCount =10000;
            int indexData = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                var temp = new Data();
                temp.Product = values[0];
                temp.Issue = values[1];
                temp.Company = values[2];
                temp.State = values[3];
                temp.ZIPcode = values[4];
                temp.ComplaintID = values[5];
                products.Add(temp);
                indexData++;
                if (indexData >= dataCount) break;
            }

            products.RemoveAt(0);

            reader.Close();
        }

       

        private double BenzerlikHesapla(String str1, String str2) { 
            
            int sameStr1 = 0;

            var list1 = str1.Split(' ');
            var list2 = str2.Split(' ');

            int longStr = list1.Length >= list2.Length ? list1.Length : list2.Length;

            foreach (var element1 in list1)
            {

                if (list2.Contains(element1)) sameStr1++;
            }

           

            return (sameStr1*100) / longStr;
        }

        List<SameData> tempList = new List<SameData>();
        List<int> threadsIDS = new List<int>();
        List<ThreadProps> threads = new List<ThreadProps>();
        Stopwatch swStart = new Stopwatch();
        int topTime = 0;
        int topWork = 0;

        private void ResetValues()
        {
            tempList.Clear();
            var source = new BindingSource();
            source.DataSource = tempList;
            dgvTable2.DataSource = source;
            threadsIDS.Clear();
            threads.Clear();
            swStart.Stop();
            swStart.Reset();
            int topTime = 0;
            int topWork = 0;
        }
        private void ProductBenzerlik(int threadCount)
        {

                bool den = ThreadPool.SetMinThreads(0, 0);
                bool den2 = ThreadPool.SetMaxThreads(threadCount, 0);
                
                swStart.Start();
            string searchAs =  combSearchAs.SelectedItem == null ? "": combSearchAs.SelectedItem.ToString();
           string sIndex = combComplaintID.SelectedItem == null ? "": combComplaintID.SelectedItem.ToString();

            threadSonucTxt.Text = "Çalışıyor....";


            foreach (var item in products)
            {
                object args = new object[3] { item, searchAs , sIndex };
                
                ThreadPool.QueueUserWorkItem(new WaitCallback(Benzerlik), args);
                   
                }

               
           
        }
       
        private async void Benzerlik(object args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Thread thread = Thread.CurrentThread;
            Array argArray = new object[2];
            argArray = (Array)args;
            var item = (Data)argArray.GetValue(0);

            var str1 = "";
            var str2 = "";
            double rate = Convert.ToDouble(nudSelectRate.Value.ToString());

            string selectAs = (string)argArray.GetValue(1);
            string sIndex = (string)argArray.GetValue(2);

            if (cbProduct.Checked)
            {
                str1 = str1 + item.Product;
            }
            if (cbIssue.Checked)
            {
                str1 = str1 + item.Issue;
            }
            if (cbCompany.Checked)
            {
                str1 = str1 + item.Company;
            }

            switch (selectAs)
            {
                case "":
                    for (var i = products.IndexOf(item) + 1; i < products.Count; i++)
                    {
                        Data item3 = products[i];

                        str2 = "";
                        if (cbProduct.Checked)
                        {
                            str2 = str2 + item3.Product;
                        }
                        if (cbIssue.Checked)
                        {
                            str2 = str2 + item3.Issue;
                        }
                        if (cbCompany.Checked)
                        {
                            str2 = str2 + item3.Company;
                        }

                        double benzerlik2 = BenzerlikHesapla(str1, str2);
                        if (benzerlik2 >= rate)
                        {

                            SameData tempSameData = new SameData();
                            tempSameData.Product1 = item.Product;
                            tempSameData.Issue1 = item.Issue;
                            tempSameData.Company1 = item.Company;
                            tempSameData.State1 = item.State;
                            tempSameData.ZIPCode1 = item.ZIPcode;
                            tempSameData.ComplaintID1 = item.ComplaintID;
                            tempSameData.Product2 = item3.Product;
                            tempSameData.Issue2 = item3.Issue;
                            tempSameData.Company2 = item3.Company;
                            tempSameData.State2 = item3.State;
                            tempSameData.ZIPCode2 = item3.ZIPcode;
                            tempSameData.ComplaintID2 = item3.ComplaintID;
                            tempSameData.Rate = benzerlik2;
                            if (tempSameData != null)
                                tempList.Add(tempSameData);
                        }
                    }
                        break;
                case "Product":
                    if(item.Product == sIndex) {
                        for (var i = products.IndexOf(item) + 1; i < products.Count; i++)
                        {

                            Data item3 = products[i];
                            if(item3.Product== sIndex)
                            {

                                str2 = "";
                                if (cbProduct.Checked)
                                {
                                    str2 = str2 + item3.Product;
                                }
                                if (cbIssue.Checked)
                                {
                                    str2 = str2 + item3.Issue;
                                }
                                if (cbCompany.Checked)
                                {
                                    str2 = str2 + item3.Company;
                                }

                                double benzerlik2 = BenzerlikHesapla(str1, str2);
                                if (benzerlik2 >= rate)
                                {

                                    SameData tempSameData = new SameData();
                                    tempSameData.Product1 = item.Product;
                                    tempSameData.Issue1 = item.Issue;
                                    tempSameData.Company1 = item.Company;
                                    tempSameData.State1 = item.State;
                                    tempSameData.ZIPCode1 = item.ZIPcode;
                                    tempSameData.ComplaintID1 = item.ComplaintID;
                                    tempSameData.Product2 = item3.Product;
                                    tempSameData.Issue2 = item3.Issue;
                                    tempSameData.Company2 = item3.Company;
                                    tempSameData.State2 = item3.State;
                                    tempSameData.ZIPCode2 = item3.ZIPcode;
                                    tempSameData.ComplaintID2 = item3.ComplaintID;
                                    tempSameData.Rate = benzerlik2;
                                    if (tempSameData != null)
                                        tempList.Add(tempSameData);
                                }
                            }


                        }
                    }
                    
                    break;
                case "Issue":
                    if (item.Issue == sIndex)
                    {
                        for (var i = products.IndexOf(item) + 1; i < products.Count; i++)
                        {

                            Data item3 = products[i];
                            if (item3.Issue == sIndex)
                            {

                                str2 = "";
                                if (cbProduct.Checked)
                                {
                                    str2 = str2 + item3.Product;
                                }
                                if (cbIssue.Checked)
                                {
                                    str2 = str2 + item3.Issue;
                                }
                                if (cbCompany.Checked)
                                {
                                    str2 = str2 + item3.Company;
                                }

                                double benzerlik2 = BenzerlikHesapla(str1, str2);
                                if (benzerlik2 >= rate)
                                {

                                    SameData tempSameData = new SameData();
                                    tempSameData.Product1 = item.Product;
                                    tempSameData.Issue1 = item.Issue;
                                    tempSameData.Company1 = item.Company;
                                    tempSameData.State1 = item.State;
                                    tempSameData.ZIPCode1 = item.ZIPcode;
                                    tempSameData.ComplaintID1 = item.ComplaintID;
                                    tempSameData.Product2 = item3.Product;
                                    tempSameData.Issue2 = item3.Issue;
                                    tempSameData.Company2 = item3.Company;
                                    tempSameData.State2 = item3.State;
                                    tempSameData.ZIPCode2 = item3.ZIPcode;
                                    tempSameData.ComplaintID2 = item3.ComplaintID;
                                    tempSameData.Rate = benzerlik2;
                                    if (tempSameData != null)
                                        tempList.Add(tempSameData);
                                }
                            }


                        }
                    }
                    break;
                case "Company":
                    if (item.Company == sIndex)
                    {
                        for (var i = products.IndexOf(item) + 1; i < products.Count; i++)
                        {

                            Data item3 = products[i];
                            if (item3.Company == sIndex)
                            {

                                str2 = "";
                                if (cbProduct.Checked)
                                {
                                    str2 = str2 + item3.Product;
                                }
                                if (cbIssue.Checked)
                                {
                                    str2 = str2 + item3.Issue;
                                }
                                if (cbCompany.Checked)
                                {
                                    str2 = str2 + item3.Company;
                                }

                                double benzerlik2 = BenzerlikHesapla(str1, str2);
                                if (benzerlik2 >= rate)
                                {

                                    SameData tempSameData = new SameData();
                                    tempSameData.Product1 = item.Product;
                                    tempSameData.Issue1 = item.Issue;
                                    tempSameData.Company1 = item.Company;
                                    tempSameData.State1 = item.State;
                                    tempSameData.ZIPCode1 = item.ZIPcode;
                                    tempSameData.ComplaintID1 = item.ComplaintID;
                                    tempSameData.Product2 = item3.Product;
                                    tempSameData.Issue2 = item3.Issue;
                                    tempSameData.Company2 = item3.Company;
                                    tempSameData.State2 = item3.State;
                                    tempSameData.ZIPCode2 = item3.ZIPcode;
                                    tempSameData.ComplaintID2 = item3.ComplaintID;
                                    tempSameData.Rate = benzerlik2;
                                    if (tempSameData != null)
                                        tempList.Add(tempSameData);
                                }
                            }


                        }
                    }
                    break;
                case "ComplaintID":
                    Data item2 = products.Where((e) => { return e.ComplaintID == sIndex; }).First();


                    str2 = "";
                    if (cbProduct.Checked)
                    {
                        str2 = str2 + item2.Product;
                    }
                    if (cbIssue.Checked)
                    {
                        str2 = str2 + item2.Issue;
                    }
                    if (cbCompany.Checked)
                    {
                        str2 = str2 + item2.Company;
                    }

                    double benzerlik = BenzerlikHesapla(str1, str2);
                    if (benzerlik >= rate)
                    {

                        SameData tempSameData = new SameData();
                        tempSameData.Product1 = item.Product;
                        tempSameData.Product2 = item2.Product;
                        tempSameData.Rate = benzerlik;

                        if (tempSameData != null)
                            tempList.Add(tempSameData);
                    }
                    break;
                default:
                    break;
            }

   

            

            ThreadProps temp;
            
            if (!threadsIDS.Contains(thread.ManagedThreadId)) { 
                threadsIDS.Add(thread.ManagedThreadId);
                temp = new ThreadProps();
                temp.ID = thread.ManagedThreadId;
                temp.workCount = 0;
                temp.workTime = 0;
                threads.Add(temp);
            }
            else
            {
                temp = threads.Where((tr) => { return tr.ID == thread.ManagedThreadId; }).First();
            }




            var time = sw.Elapsed;
            temp.workTime += Convert.ToInt32(time.TotalMilliseconds);
            temp.workCount++;
            topWork++;
            if ((products.Count - 1) == products.IndexOf(item))
            {
                ThreadPool.SetMaxThreads(0, 0);
                var time2 = swStart.Elapsed;
                topTime = Convert.ToInt32(time2.TotalMilliseconds);
                DisplayData();
            }
        }       
        
        private void DisplayData()
        {
            threadSonucTxt.Text= string.Empty;  
            String threadTxt = "";

            foreach (var tr in threads)
            {
                threadTxt += $"Thread ID: {tr.ID} , Çalışma Zamanı : {tr.workTime} , Yaptığı İş Miktarı: {tr.workCount} \r";
            }
            threadTxt += $"Toplam Geçen Süre : {topTime} , Toplam Yapılan İş : {topWork}";

            threadSonucTxt.Text = threadTxt;

            Console.WriteLine("Start Table");


            var source = new BindingSource();

            source.DataSource = tempList;

            

            

            dgvTable2.DataSource = source;



            
                if (!cbProductTable.Checked)
                { dgvTable2.GridView.Columns[0].Visible = false; }

                if (!cbIssueTable.Checked)
                { dgvTable2.GridView.Columns[1].Visible = false; }

                if (!cbCompanyTable.Checked)
                { dgvTable2.GridView.Columns[2].Visible = false; }

                if (!cbStateTable.Checked)
                { dgvTable2.GridView.Columns[3].Visible = false; }

                if (!cbZIPCodeTable.Checked)
                { dgvTable2.GridView.Columns[4].Visible = false; }

                if (!cbComplaintIDTable.Checked)
                { dgvTable2.GridView.Columns[5].Visible = false; }

                if (!cbProductTable.Checked)
                { dgvTable2.GridView.Columns[6].Visible = false; }

                if (!cbIssueTable.Checked)
                { dgvTable2.GridView.Columns[7].Visible = false; }

                if (!cbCompanyTable.Checked)
                { dgvTable2.GridView.Columns[8].Visible = false; }

                if (!cbStateTable.Checked)
                { dgvTable2.GridView.Columns[9].Visible = false; }

                if (!cbZIPCodeTable.Checked)
                { dgvTable2.GridView.Columns[10].Visible = false; }

                if (!cbComplaintIDTable.Checked)
                { dgvTable2.GridView.Columns[11].Visible = false; }

             
        }

        private void btnCalistir_ClickAsync(object sender, EventArgs e) 
        {
            ResetValues();
            int threadCount = Convert.ToInt32(nudThread.Value.ToString());
            ProductBenzerlik(threadCount);

        }

        private void combSearchAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            



            switch (combSearchAs.SelectedItem)
            {
                case "Product":
                    List<String> list = new List<String>();
                    foreach (var item in products)
                    {
                       list.Add(item.Product);
                    }
                    List<String> list2 = new List<String>();
                   list2 = list.Distinct().ToList();
                    combComplaintID.Items.Clear();
                    foreach (var item2 in list2)
                    {
                        combComplaintID.Items.Add(item2);
                    }
                    combComplaintID.Visible= true;
                    break;
                case "Issue":
                    List<String> list3 = new List<String>();
                    foreach (var item in products)
                    {
                        list3.Add(item.Issue);
                    }
                    List<String> list4 = new List<String>();
                    list4 = list3.Distinct().ToList();
                    combComplaintID.Items.Clear();
                    foreach (var item2 in list4)
                    {
                        combComplaintID.Items.Add(item2);
                    }
                    combComplaintID.Visible = true;
                    break;
                case "Company":
                    List<String> list5 = new List<String>();
                    foreach (var item in products)
                    {
                        list5.Add(item.Company);
                    }
                    List<String> list6 = new List<String>();
                    list6 = list5.Distinct().ToList();
                    combComplaintID.Items.Clear();
                    foreach (var item2 in list6)
                    {
                        combComplaintID.Items.Add(item2);
                    }
                    combComplaintID.Visible = true;
                    break;
                case "ComplaintID":
                    combComplaintID.Items.Clear();
                    foreach (var item in products)
                    {
                        combComplaintID.Items.Add(item.ComplaintID);
                    }
                    combComplaintID.Visible = true;
                    break;
                default:
                    break;
            }
        }


    }


}

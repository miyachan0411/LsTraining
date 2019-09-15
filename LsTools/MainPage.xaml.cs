using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKit;
using Xamarin.Forms;

namespace LsTools
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            using (var db = new DBModel())
            {
                
                // DB追加
                //db.News.Add(new NEWS { Id = 2, Text = "test" , Url = "http://google.co.jp" , Description = "test" });

                // 変更内容を保存
                //var count = db.SaveChanges();
                

                //Debug.WriteLine("{0} records saved to database", count);

                foreach (var news in db.News)
                {
                    // 取得した情報を設定
                    this.ListViewMenu.ItemsSource = db.News;
                }
            }

            //// リストボタンを押下した場合の処理
            //ListViewMenu.ItemSelected += async (sender, e) =>
            //{
            //    if (e.SelectedItem == null)
            //    {
            //        return;
            //    }
            //    var browser = new WebView
            //    {
            //        Source = "http://xamarin.com"
            //    };
            //};
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {

            var browser = new WebView
            {
                Source = "http://xamarin.com",
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            //var item = args.SelectedItem as Itemmodel;
            //if (item == null)
            //    return;

            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            //// Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }
    }
}
                        
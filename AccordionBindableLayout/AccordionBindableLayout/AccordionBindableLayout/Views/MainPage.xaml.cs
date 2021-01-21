using Syncfusion.XForms.Accordion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AccordionBindableLayout
{
    public partial class MainPage : ContentPage
    {
        //SfAccordion Accordion;
        public MainPage()
        {
            InitializeComponent();

            //ItemInfoRepository viewModel = new ItemInfoRepository();
            //this.BindingContext = viewModel;
            //Accordion = new SfAccordion();
            //this.Content = Accordion;
            //DataTemplate ItemTemplate = new DataTemplate(() =>
            //{
            //    AccordionItem accordionItem = new AccordionItem();
            //    var headerGrid = new Grid();
            //    var header = new Label();
            //    header.SetBinding(Label.TextProperty, new Binding("Name"));
            //    headerGrid.Children.Add(header);
            //    accordionItem.Header = headerGrid;
            //    var contentGrid = new Grid();
            //    var content = new Label();
            //    content.SetBinding(Label.TextProperty, new Binding("Description"));
            //    contentGrid.Children.Add(content);
            //    accordionItem.Content = contentGrid;
            //    return accordionItem;
            //});
            //BindableLayout.SetItemTemplate(Accordion, ItemTemplate);
            //BindableLayout.SetItemsSource(Accordion, viewModel.Info);
        }
    }
}

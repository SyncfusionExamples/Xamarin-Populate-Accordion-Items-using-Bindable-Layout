# How to populate AccordionItems using Bindable layout?

The [SfAccordion](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.Expander.XForms~Syncfusion.XForms.Accordion.SfAccordion.html) allows to set a collection of items by setting `BindableLayout.ItemsSource` and `BindableLayout.ItemTemplate` properties. The Accordion supports Bindable Layout in Xamarin.Forms version 3.5 and above.

```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Accordion;assembly=Syncfusion.Expander.XForms"
             xmlns:local="clr-namespace:AccordionBindableLayout"
             x:Class="AccordionBindableLayout.MainPage">
    <syncfusion:SfAccordion x:Name="Accordion" BindableLayout.ItemsSource="{Binding Info}">
        <BindableLayout.ItemTemplate>
            <DataTemplate>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Label Text="{Binding Name}"/>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Label Text="{Binding Description}"/>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
            </DataTemplate>
        </BindableLayout.ItemTemplate>
    </syncfusion:SfAccordion> 
</ContentPage>   
```

You can also refer our UG documentation to know more about [BindableLayout](https://help.syncfusion.com/xamarin/accordion/bindablelayout).

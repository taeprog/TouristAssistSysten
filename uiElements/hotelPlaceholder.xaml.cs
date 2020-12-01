using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class hotelPlaceholder : UserControl
    {
        public hotelPlaceholder(Hotel hotel, List<Room> rooms)
        {
            InitializeComponent();
            descrUI.Text = hotel.description;
            nameUI.Text = hotel.name;
            adressUI.Text = hotel.address;
            idUI.Text = "#"+hotel.id.ToString();
            foreach(Room item in rooms)
            {
                var roomInfo = new TextBlock();
                roomInfo.Text = string.Format("ID: {0} | Цена: {1} |  Удобства: {2}",item.id,item.price,item.conviniences);
                StackPanelRooms.Children.Add(roomInfo);
            }
           


        }

    }
}

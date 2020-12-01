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

namespace TouristAssistSistem.uiElements
{
    /// <summary>
    /// Логика взаимодействия для solutionRoutePlaceholder.xaml
    /// </summary>
    public partial class solutionRoutePlaceholder : UserControl
    {
        public solutionRoutePlaceholder(Route route)
        {
            InitializeComponent();

            descrUI.Text = route.information + "\n" + string.Format("Расстояние: {0} | Сложность: {1} | Стоимость: {2} | Высота поверхности: {3}", route.distance, route.difficulty, route.cost, route.heightDiff);
            nameUI.Text = route.name  + " #" + route.id.ToString();
        }
    }
}

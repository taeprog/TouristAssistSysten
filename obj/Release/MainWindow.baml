   M S B A M L   `   `   `  ���� N  JTouristAssistSistem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TouristAssistSistemTouristAssistSistem  $    TouristAssistSistem.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:TouristAssistSistem     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � UseLayoutRounding  .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���   � Title$ Window1��$	��525��$��729.5�����	#FFD3F3FF � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=� � WindowStyle$
 None=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     	Direction$	 348Q�	   ShadowDepth$	 0Q�
   
BlurRadius$
 74Q�   Opacity$ 0.925Q�.��� .+��� $��Right=� �� Orientation$ Vertical=�.+��� -   $��13(�$��	0 10 10 0q�$��30��+  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#FFECECEC   MaterialDesignOutlinedButton#��[ ���	#FF979797
������ ��0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Shutdown=���  �� Padding$ 15q�$��Center=�$��0 30 0 0q�$	��500�� �� CornerRadius$ 5��$	��400��
�������   $
 23Q�   Color$ 	#FFBFE5F3��$	 100Q�$	 0Q�._��� .+��� -    ��Name$ label��$��3��$��Center=�$��20(�$��	0,18,0,17q�$
��Bold"�53Хотите запланировать отдых?� $��	18 0 18 0q� � ColumnDefinitions �� $	��50* ��� $	��50* �.+��� -    ��Name$ cashUI��$��0 0 18 0q�.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �   �   
SuffixText$
 RUB ��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите сумму��$��0��$��Center=�$��25�� �� 
CaretBrush �	#FFA4A4A4�� -   $ daysUI��
 �   �$��18 0 0 0q�$) #Введите кол-во дней��$��1��$��Center=�$��25�� �	#FFA4A4A4�� -   $��	18 15 0 0q�$	��200��$
��Left=� �	#FFFFDCA9 # MaterialDesignFlatLightBgButton#��[ $ ��Запланировать�����	#FF815411���	#FFFFB74D���	#FFFBFBFB�� $��3��$��Center=�$��20(�$��	0,18,0,17q�$
��Bold"�ЕщеA�  A� Rows$ 1�� A� Columns$ 2��.+��� $ 15q�$	��200��$ 5��$	��400��
�������   $
 25Q�$ 	#FFEAE6E6��$	 100Q�$	 0Q�._��� .+��� $��0 0 0 15q�$��50��*(Список всех доступных�� отелей%  MaterialDesignThemes.Wpf.Badged    ControlzEx.BadgedEx   BadgePlacementMode$ TopRight=�   BadgeColorZoneMode$ Accent=�   Badge   *Hotel+.���� -    �	#FFECECEC#��[ $��Открыть отели�����	#FF979797�� $ 15q�$	��200��$ 5��$	��400��
�������   $
 25Q�$ 	#FFEAE6E6��$	 100Q�$	 0Q�._��� .+��� $��0 0 0 15q�$��50��*(Список всех доступных�� маршрутов  $ Accent=�   *Routes+.���� -    �	#FFECECEC#��[ $%��Список маршрутов�����	#FF979797
������ 
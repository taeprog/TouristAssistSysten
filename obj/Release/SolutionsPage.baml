   M S B A M L   `   `   `  ���� N  JTouristAssistSistem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TouristAssistSistemTouristAssistSistem  '    !TouristAssistSistem.SolutionsPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:TouristAssistSistem     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � UseLayoutRounding  .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���   � Title$ Window1��$	��525��$��729.5�����	#FFD3F3FF � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ CanMinimize=� � WindowStyle$
 None=�$y�Visible=�.��� .+��� $��Right=� �� Orientation$ Vertical=�.+��� -   $��13(�$��	0 10 10 0q�$��30��+  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#FFECECEC   MaterialDesignOutlinedButton#��[ ���	#FF979797
������ ��0  *MaterialDesignThemes.Wpf.PackIconExtension  	   Kind$	 	ArrowBack=��� 
 �� Padding$
 15q�$��	0 10 0 10q�$	��500�� �� CornerRadius$ 5��$	��400��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 25Q�   Color$ 	#FFBFE5F3��   	Direction$	 100Q�   ShadowDepth$ 0Q�._��� .���� -    ��Name$ 
StackPanel��.+��� -    ��Name$ label��$��3��$��Center=�$��20(�$��	0,18,0,17q�$
��Bold"�'%Вот что вам подойдет�  � ColumnDefinitions �� �� .+��� $
 15q�$	��Top=�$	��200��$��0��$ 5��$	��200��
�������   $ 25Q�$ 	#FFEAE6E6��$	 100Q�$ 0Q�._��� -   $ StackPanelRoom��.+��� -   $ 
nameRommUI��$��0 0 0 15q�$��50��$��15(�$
��Bold"�
Отель�� -   $ descrRoomUI��$��0 0 0 15q�$��50��$
��Wrap=�$��14(�$��Normal"�
День 1�� -   $ StackPanelRoutes��$��1��
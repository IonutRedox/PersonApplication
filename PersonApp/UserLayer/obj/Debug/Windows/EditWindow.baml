   M S B A M L   `   `   `  ����D  @UserLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UserLayer.WindowsUserLayer.Windows  5   	   3clr-namespace:UserLayer.HelperUserLayer.Helper  5   	   ;"clr-namespace:UserLayer.ViewModelsUserLayer.ViewModels  5
      "    UserLayer.Windows.EditWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UserLayer.Windows     5   	   -xcclr-namespace:UserLayer.Helper     5   	   4model"clr-namespace:UserLayer.ViewModels     5
        � Title$  
EditWindow��5   	   $	��310��6   $	��240��6)   #   UserLayer.Helper.DialogCloser   DialogResult 5   	   �� *DialogResult+.��5      �� $��10q�6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Type:��6   �� 5      -   5         ��Name$ txtType��5      $	��100��6'   $��20��6�   $��	53,10,0,0q�6�   ��64   �� *SelectedType+ �� UpdateSourceTrigger$ PropertyChanged=�{�6v   �� *	TypeField+6�   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��Identifier:��6   $��0,10,0,0q�6*   �� 5      -   5        $ txtIdentifier��5      $	��100��6-   {�.  $��20��6h   $��	30,10,0,0q�6t   ��6K   �� *
Identifier+6t   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��Name:��6   $��0,10,0,0q�6$   �� 5      -   5        $ txtName��5      $	��100��6'   $��20��63   $��	45,10,0,0q�6y   ��6?   �� *Name+$ PropertyChanged=�6y   5      �� 5    
   $ 
Horizontal=�6   .+�5!      �� $��Surname:��6   $��0,10,0,0q�6'   �� 5"      -   5        $��
txtSurname��5"      $	��100��6(   $��20��6q   $��	30,10,0,0q�6}   ��64   �� *	Surname+$ PropertyChanged=�6}   5#      �� 5$   
   $ 
Horizontal=�6   .+�5%      �� -   5         ��Name$ lblYear��5%      $��
YearStudy:��6%   $��0,10,0,0q�6;   �� 5&      -   5        $ txtYearStudy��5&      $	��100��6k   $��20��6x   $��	25,10,0,0q�6�   ��6,   �� *	YearStudy+$ PropertyChanged=�6�   5'      �� 5(   
   $ 
Horizontal=�6   .+�5)      �� -   5        $ lblGrade��5)      $��Grade:��6'   $��0,10,0,0q�68   �� 5*      -   5        $ txtGrade��5*      $	��100��6c   $��20��6q   $��	45,10,0,0q�6}   ��6(   �� *Grade+$ PropertyChanged=�6}   5+      �� 5,   
   $ 
Horizontal=�6   .+�5-      �� -	   5         ��Name$ saveBtn��5-      $
��Save��6&   $��60��6[   $��19��6f   $��15q�6r   ��65   ��  �� Path$ SaveCommand�6r   �� 5.      -
   5        $ 	cancelBtn��5.      $��Cancel��6)    �� IsCancel . $��60��6K   $��20��6V   $��15q�6b   5/      52      53      
   M S B A M L   `   `   `  ����M  IDesktopContactsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DesktopContactsAppDesktopContactsApp  5   	   I)clr-namespace:DesktopContactsApp.ControlsDesktopContactsApp.Controls  5   	   #    DesktopContactsApp.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DesktopContactsApp     5   	   8uc)clr-namespace:DesktopContactsApp.Controls     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5      �� $��10q�6   .+�5   
   �� -   5        $��Add New Contact��5      $��0 0 0 5q�6@   �� 5   
   -   5        $��22(�5         WatermarkTextBox#��[  5      
 � Tag$ Search��5      �� 5   
   -   5         ��Name$ contactsListView��5      $	��280��5      $��0,5,0,0q�5      ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ Stretch=�6C   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   � .+�5   &   �� �� 5   &   $��Border��6?    �� CornerRadius$ 10��6-   6?   5   #    �� Triggers 5   "   P� 5    &   	 P� Property	 �@��
IsSelected
 P� Value$

 true��6D   . �5!   *   ��  �� 
TargetName$ Border��61    � �� �	#20005A9C6[   �� 5"   *   $ Border��61    � ��$ 2q�6`   �� 5#   *   $ Border��61    � �� �	#60005A9C6\   5$   '   P� 5%   &   	 �@J�IsMouseOver$

 true��6E   . �5&   *   �� $ Border��61    � �� �	#20005A9C6[   �� 5'   *   $ Border��61    � ��$ 2q�6`   �� 5(   *   $ Border��61    � �� �	#60005A9C6\   5)   '   5+      5-      5.      ��50      �� 51      .R�52      0   *DesktopContactsApp.Controls.ContactControl     Contact 6(   �� 53      55      57      58      
   M S B A M L   `   `   `  ����L  HEmployeesDataBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EmployeesDataBaseEmployeesDataBase  5   	   "    EmployeesDataBase.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:EmployeesDataBase     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridAllEmp��5
      $
��Left=�6+   $	��306��6F   $��	93,57,0,0q�6S   $	��Top=�6f   $	��361��6~   5      �� 5   
   $��Add Eployee��6   $
��Left=�6&   $��
562,57,0,0q�6A   $	��Top=�6U   $	��203��6m   �� 5   
   -   5         ��Name$ firstNameTxt��5      $
��Left=�6(   $��23��6C   $��
562,93,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $��
First name��6w   $	��Top=�6�   $	��168��6�   �� 5   
   -   5        $ lastNameTxt��5      $
��Left=�6'   $��23��6B   $��562,133,0,0q�6N   $
 Wrap=�6c   $��	Last name��6w   $	��Top=�6�   $	��168��6�   �� 5   
   $��Delete or Update��6   $
��Left=�6+   $��562,214,0,0q�6F   $	��Top=�6[   $	��120��6s   �� 5   
   -   5         ��Name$ editID��5      $��ID��6    $
��Left=�6-   $��562,238,0,0q�6H   $	��Top=�6]   $	��120��6u   �� 5   
   -   5        $ editFirstNameTxt��5      $
��Left=�6,   $��23��6G   $��562,269,0,0q�6S   $
 Wrap=�6h   $��
First name��6|   $	��Top=�6�   $	��168��6�   �� 5   
   -   5        $ editLastNameTxt��5      $
��Left=�6+   $��23��6F   $��562,297,0,0q�6R   $
 Wrap=�6g   $��	Last name��6{   $	��Top=�6�   $	��168��6�   �� 5   
   -   5        $��Add Employee��5      $
��Left=�6(   $��562,177,0,0q�6C   $	��Top=�6X   $	��168��6p   6|   �� 5   
   -   5         ��Name$ 	UpdateBtn��5      $��Update��6$   $
��Left=�65   $��565,343,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -	   5        $ 	deleteBtn��5      $��Delete��6$   $
��Left=�65   $��654,343,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   $��Employees Managment CRUD ��6   $
��Left=�64   $��	93,19,0,0q�6O   $	��Top=�6b   $	��361��6z   $��16(�6�   $
��Bold"�6�   5      5      
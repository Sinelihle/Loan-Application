   M S B A M L   `   `   `  ����J  FLoanApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LoanApplicationLoanApplication  5   	   $    LoanApplication.VehicleLoanWPF   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LoanApplication     5   	     � Title$  Vehicle Loan��5   	   $��755.172��6   $��865.517��6/   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF868489��6    � Offset$ 1Q�6-   � 5      $ 	#FF3B4D57��6   5      .��5      � .+�5   
   �� $��Vehicle Loan��6   $
��Left=�6'   $��
301,37,0,0q�6B   $	��Top=�6V   $	��205��6n   $��Center=�6z   $��Center=�6�   $��15(�6�   ���#fff$
��Bold"�6�   �� 5   
   $��Model And Make��6   $
��Left=�6)   $��
60,127,0,0q�6D   $	��Top=�6X   $��37��6p   $	��190��6|   
�������$��13(�6�   $��Center=�6�   �� 5   
   $��Purchase Price��6   $��60,169,608,502q�6)   
�������$��Center=�6T   $��13(�6v   �� 5   
   $��Total Deposit��6   $��60,239,608,439q�6)   
�������$��Center=�6T   $��13(�6v   �� 5   
   $��Interest Rate��6    J� RenderTransformOrigin$ 0.244,3.852&�6(   $��60,290,608,387q�6L   
�������$��Center=�6w   $��13(�6�   �� 5   
   $!��Estimated Insurance Premium��6   $��60,337,608,331q�66   
�������$��Center=�6a   $��13(�6�   �� 5   
   -   5         ��Name$ txtModelandMakeBox��5      $
��Left=�6.   $��23��6I   $��301,127,0,0q�6U    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��177��6�   �� 5   
   -   5        $ txtPriceBox��5      $
��Left=�6'   $��23��6B   $��301,183,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��177��6�   $ 0.516,1.094&�6�   6�   �� 5   
   -   5        $ txtDepositBox��5      $
��Left=�6)   $��23��6D   $��301,239,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��177��6�   $ 0.438,1.314&�6�   6�   �� 5   
   -   5        $ 
premiumBox��5      $
��Left=�6&   $��23��6A   $��301,356,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��177��6�   6�   �� 5   
   -   5         ��Name$ interestSlider��5      	 �� TickFrequency$	 1Q�6)   
 �� IsSnapToTickEnabled
 . $
��Left=�6W   $��301,296,0,0q�6r   $	��Top=�6�   $��25��6�   $	��154��6�    � Minimum$ 1Q�6�    � Maximum$	 100Q�6�    � Value$ 1Q�6�   6�   �� 5   
   -   5         ��Name$ interestTextBox��5      $
��Left=�6-   $��455,290,0,0q�6H   $
��Wrap=�6]   $�� ��6q   $	��Top=�6y   $��46��6�   $��31��6�   
������� �� TextAlignment$
 Left=�6�   �� 5   
   -   5         ��Name$ showBtn��5      $
��Show��6"   $��60,662,726,10q�61   
���   �$
��Left=�6\   
�������6�   �� 5   
   -   5        $ backBtn��5      $
��Back��6"   $��675,662,108,10q�61   
���   �
�������$��Right=�6p   6�   �� 5   
   -	   5        $ viewBtn��5      $��View  Receipt��6"   $��334,662,403,10q�6:   
���   �
�������6y   �� 5   
   -
   5        $ 
modelBlock��5      $
��Left=�6(   $��
60,470,0,0q�6C   $
��Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��418��6�   $��30��6�   
�������$��13(�6�   �� 5    
   -   5        $ depositBlock��5       $
��Left=�6*   $��
60,505,0,0q�6E   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��418��6�   $��30��6�   
�������$��13(�6�   �� 5!   
   -   5        $ purchasePriceBlock��5!      $
��Left=�60   $��
60,540,0,0q�6K   $
��Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��418��6�   $��30��6�   
�������$��13(�6�   �� 5"   
   -   5        $ interestRateBlock��5"      $
��Left=�6/   $��
60,570,0,0q�6J   $
��Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��418��6�   $��30��6�   
�������$��13(�6�   �� 5#   
   -   5        $ insurancePremiumBlock��5#      $
��Left=�63   $��
60,605,0,0q�6N   $
��Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��418��6�   $��30��6�   
�������$��13(�6�   �� 5$   
   $��Total On Expenses��6   $��60,398,608,281q�6,   
�������$��Center=�6W   $��13(�6y   �� 5%   
   -   5        $ totalExpensesBtn��5%      $
��Left=�6,   $��23��6G   $��301,404,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��177��6�   6�   �� 5&   
   $��Gross Income��6   $
��Left=�6'   $��	60,85,0,0q�6B   $	��Top=�6U   $��37��6m   $	��190��6y   
�������$��13(�6�   $��Center=�6�   �� 5'   
   -   5        $ txtGrossIncome��5'      $
��Left=�6*   $��23��6E   $��
301,85,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��177��6�   6�   5*      5+      
   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   CaptionButtonStyleKey  �� 
TargetType �� Property �� Value'   !System.Windows.Shell.WindowChrome  GrayCaptionButtonStyleKey �� BasedOn �� 
TargetType ��Name ��Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� 
TargetName �� TargetProperty	 W� To g� Duration W� EasingFunction.   (System.Windows.Media.Animation.CubicEase7   1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode4   .System.Windows.Media.Animation.ExponentialEase  RedCaptionButtonStyleKey �� Triggers P� Property P� Value �� 
TargetName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %,  &	        &	 �    7   &	 �    7   �� 5      "  ��5   	   .�5   
   ��  �@�OverridesDefaultStyle$
 True��62   �� 5   
    � ��$ False��6&   �� 5	   
    � ��$ Center=�67   �� 5
   
    � ��$ Center=�65   �� 5   
    �@J�SnapsToDevicePixels$
 True��60   �� 5   
    �@�UseLayoutRounding$
 True��6.   �� 5   
     �@  IsHitTestVisibleInChrome$
 True��6B   �� 5   
    �@�FocusVisualStyle 6-   Z� 5      �� 5      8   "  ��5   	   .�5   
   ��  � ��
 �����6'   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ border��5      #��z��5      �� 5      $ contentPresenter��5      #��z��5       #��z��5!      $|�False��5"       5#        5$      CommonStates��. 5%   "     
Normal��.	 5&   &   �� .��5'   *   W� $
 border��5(   -   $ (UIElement.Opacity)�5)   -    0.05*   -   $ 	0:0:0.150D�5+   -    5,   .     5-   2   $ EaseIn=�6<   5/   +   50   '   51   #     52   "   	MouseOver��.	 53   &   �� .��54   *   W� $
 border��55   -   $ (UIElement.Opacity)�56   -    0.657   -   $ 	0:0:0.150D�58   -    59   .     5:   2   $ EaseOut=�6B   5<   +   5=   '   5>   #     5?   "   Pressed��.	 5@   &   �� .��5A   *   W� $
 border��5B   -   $ (UIElement.Opacity)�5C   -    15D   -   $ 	0:0:0.150D�5E   -    5F   .     5G   2   $ EaseOut=�6B   5I   +   5J   '   5K   #     5L   "   Disabled��.	 5M   &   �� .��5N   *   W� $
 border��5O   -   $ (UIElement.Opacity)�5P   -    0.05Q   -   $ 	0:0:0.150D�5R   -    5S   .     5T   2   $ EaseIn=�6<   5V   +   W� 5W   *   $
 contentPresenter��5X   -   $ (UIElement.Opacity)�5Y   -    0.35Z   -   $ 	0:0:0.150D�5[   -    5\   .     5]   2   $ EaseOut=�6B   5_   +   5`   '   5a   #   5b      5d      5e      5g      5h      �� 5k      8   "  ��5n   	   .�5o   
   ��  � ��
 �  ��6'   �� 5p   
    � �� 5q      �� 5r      " ��6"   .R�5s      � .+�5t      �� $ border��5u      #��z��5v      �� 5w      $ contentPresenter��5x      #��z��5y      #��z��5z      $|�False��5{       5|        5}      CommonStates��. 5~   "     
Normal��.	 5   &   �� .��5�   *   W� $
 border��5�   -   $ (UIElement.Opacity)�5�   -    0.05�   -   $ 	0:0:0.150D�5�   -    5�   .     5�   2   $ EaseIn=�6<   5�   +   5�   '   5�   #     5�   "   	MouseOver��.	 5�   &   �� .��5�   *   W� $
 border��5�   -   $ (UIElement.Opacity)�5�   -    0.65�   -   $ 	0:0:0.150D�5�   -    5�   .     5�   2   $ EaseOut=�6B   5�   +   5�   '   5�   #     5�   "   Pressed��.	 5�   &   �� .��5�   *   W� $
 border��5�   -   $ (UIElement.Opacity)�5�   -    15�   -   $ 	0:0:0.150D�5�   -    5�   .     5�   2   $ EaseOut=�6B   5�   +   5�   '   5�   #     5�   "   Disabled��.	 5�   &   �� .��5�   *   W� $
 border��5�   -   $ (UIElement.Opacity)�5�   -    0.05�   -   $ 	0:0:0.150D�5�   -    5�   .     5�   2   $ EaseIn=�6<   5�   +   W� 5�   *   $
 contentPresenter��5�   -   $ (UIElement.Opacity)�5�   -    0.35�   -   $ 	0:0:0.150D�5�   -    5�   .     5�   2   $ EaseOut=�6B   5�   +   5�   '   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� $ contentPresenter��6%    � ��
 �����6e   5�      5�      5�      5�      5�      
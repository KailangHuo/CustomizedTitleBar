using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shell;
using Brush = System.Windows.Media.Brush;


namespace CustomizedTitleBar; 

public partial class CustomizedTitileBar_UserControl : UserControl, INotifyPropertyChanged {

    #region CONSTRUCTION

    public CustomizedTitileBar_UserControl() {
        InitializeComponent();
        this.DataContext = this;
        this.BorderThickness = new Thickness(1);
        this.Foreground = (Brush)new BrushConverter().ConvertFromString("Black");
        this.Background = (Brush)new BrushConverter().ConvertFromString("White");
        this.IsNormalWindowState = true;
        this.IsResizable = true;
        this.Height = 30.00;
        this.Loaded += OnLoaded;
    }

    private void OnLoaded(object o, RoutedEventArgs e) {
        this.HostWindow.StateChanged += HostWindow_StateChanged;
        this.IsResizable = this.HostWindow.ResizeMode == ResizeMode.CanResize;
        this.Title = this.HostWindow.Title;
        Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
        this.Icon.Source = Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            
        
        // 创建一个WindowChrome对象
        WindowChrome windowChrome = new WindowChrome();
        // 设置WindowChrome的属性
        windowChrome.CornerRadius = new CornerRadius(0);
        windowChrome.GlassFrameThickness = new Thickness(0);
        windowChrome.ResizeBorderThickness = new Thickness(5);
        windowChrome.UseAeroCaptionButtons = false;
        
        // 将WindowChrome对象赋值给当前窗口
        WindowChrome.SetWindowChrome(this.HostWindow, windowChrome);
        
    }
    
    private void HostWindow_StateChanged(object sender, EventArgs e)
    {
        if (this.HostWindow.WindowState == WindowState.Maximized)
        {
            IsNormalWindowState = false;
            this.MainGrid.Margin = new Thickness(8, 8, 8, 0);

        }
        else if (this.HostWindow.WindowState == WindowState.Normal)
        {
            IsNormalWindowState = true;
            this.MainGrid.Margin = new Thickness(0, 0, 0, 0);
            
        }
    }

    #endregion

    #region NOTIFIABLE_PROPERTIES

    public static readonly DependencyProperty HostWindowProperty 
        = DependencyProperty.Register(
            nameof(HostWindow), 
            typeof(Window), 
            typeof(CustomizedTitileBar_UserControl),
            new PropertyMetadata()
        );

    public Window HostWindow {
        get { return (Window)GetValue(HostWindowProperty); }
        set { SetValue(HostWindowProperty,value); }
    }
    
    private bool _isNormalWindowState;

    public bool IsNormalWindowState {
        get {
            return _isNormalWindowState;
        }
        private set {
            if(_isNormalWindowState == value)return;
            _isNormalWindowState = value;
            RisePropertyChanged(nameof(IsNormalWindowState));
        }
    }

    private bool _isResizable;

    public bool IsResizable {
        get {
            return _isResizable;
        }
        private set {
            if(_isResizable == value)return;
            _isResizable = value;
            if (_isResizable) {
                this.NormalizeButton.IsHitTestVisible = true;
                this.MaximizeButton.IsHitTestVisible = true;
            }
            else {
                this.NormalizeButton.IsHitTestVisible = false;
                this.NormalizeButton.Content = null;
                this.MaximizeButton.IsHitTestVisible = false;
                this.MaximizeButton.Content = null;
            }
            RisePropertyChanged(nameof(IsResizable));
        }
    }

    private string _title;

    public string Title {
        get {
            return _title;
        }
        set {
            if (_title == value) return;
            _title = value;
            RisePropertyChanged(nameof(Title));
        }
    }


    #endregion

    #region FRONT_OPERATION

    private void MinimizeButton_OnClick(object sender, RoutedEventArgs e) {
        this.HostWindow.WindowState = WindowState.Minimized;
    }

    private void MaximizeButton_OnClick(object sender, RoutedEventArgs e) {
        this.HostWindow.WindowState = WindowState.Maximized;
        
    }

    private void CloseButton_OnClick(object sender, RoutedEventArgs e) {
        this.HostWindow.Close();
    }

    private void NormalizeButton_OnClick(object sender, RoutedEventArgs e) {
        this.HostWindow.WindowState = WindowState.Normal;
        
    }

    #endregion
    
    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void RisePropertyChanged(string propertyName) {
        if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
    
    
}
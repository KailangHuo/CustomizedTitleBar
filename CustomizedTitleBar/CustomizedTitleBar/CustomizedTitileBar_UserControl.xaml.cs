

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Media;
using System.Windows.Shell;


namespace CustomizedTitleBar; 

public partial class CustomizedTitileBar_UserControl : UserControl, INotifyPropertyChanged {

    #region CONSTRUCTION

    public CustomizedTitileBar_UserControl() {
        InitializeComponent();
        this.DataContext = this;
        this.BorderThickness = new Thickness(1);
        this.DrawingColor = (Brush)new BrushConverter().ConvertFromString("Black");
        this.Background = (Brush)new BrushConverter().ConvertFromString("White");
        this.HasTitle = true;
        this.Height = 29.00;
        this.IsNormalWindowState = true;
        this.IsResizable = true;
        this.Loaded += OnLoaded;
    }

    private void OnLoaded(object o, RoutedEventArgs e) {
        this.HostWindow.StateChanged += HostWindow_StateChanged;
        IsResizable = this.HostWindow.ResizeMode == ResizeMode.CanResize;
        TitleStr = this.HostWindow.Title;
        
        // 创建一个WindowChrome对象
        WindowChrome windowChrome = new WindowChrome();
        // 设置WindowChrome的属性
        windowChrome.CornerRadius = new CornerRadius(0);
        windowChrome.GlassFrameThickness = new Thickness(-1);
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
        }
        else if (this.HostWindow.WindowState == WindowState.Normal)
        {
            IsNormalWindowState = true;
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
    
    public ImageSource IconSource { get; set; }
    
    public Brush DrawingColor { get; set; }

    private bool _isNormalWindowState;

    public bool IsNormalWindowState {
        get {
            return _isNormalWindowState;
        }
        set {
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
        set {
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
    
    private bool _hasTitle;

    public bool HasTitle {
        get {
            return _hasTitle;
        }
        set {
            if(_hasTitle == value)return;
            _hasTitle = value;
            RisePropertyChanged(nameof(HasTitle));
        }
    }

    private string _titleStr;

    public string TitleStr {
        get {
            return _titleStr;
        }
        set {
            if (_titleStr == value) return;
            _titleStr = value;
            RisePropertyChanged(nameof(TitleStr));
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
    
    
    public event PropertyChangedEventHandler? PropertyChanged;

    public void RisePropertyChanged(string propertyName) {
        if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
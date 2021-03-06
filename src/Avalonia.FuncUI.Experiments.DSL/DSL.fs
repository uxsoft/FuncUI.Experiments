module Avalonia.FuncUI.Experiments.DSL.DSL

open Avalonia.Controls
open Avalonia.Controls
open Avalonia.Controls.Primitives
open Avalonia.Controls.Shapes
open Avalonia.FuncUI.Experiments.DSL
open Avalonia.FuncUI.Experiments.DSL.ProgressBar

let panel = Panel.PanelBuilder<Panel>()
let canvas = Canvas.CanvasBuilder<Canvas>()
let dockPanel = DockPanel.DockPanelBuilder<DockPanel>()
let grid = Grid.GridBuilder<Grid>()
let stackPanel = StackPanel.StackPanelBuilder<StackPanel>()
let wrapPanel = WrapPanel.WrapPanelBuilder<WrapPanel>()
let itemsRepeater = ItemsRepeater.ItemsRepeaterBuilder<ItemsRepeater>()
let uniformGrid = UniformGrid.UniformGridBuilder<UniformGrid>()

let rectangle = Rectangle.RectangleBuilder<Rectangle>()
let ellipse = Ellipse.EllipseBuilder<Ellipse>()
let line = Line.LineBuilder<Line>()
let polyline = Polyline.PolylineBuilder<Polyline>()
let polygon = Polygon.PolygonBuilder<Polygon>()
let path = Path.PathBuilder<Path>()

let layoutTransform = LayoutTransformControl.LayoutTransformControlBuilder<LayoutTransformControl>()
let viewBox = ViewBox.ViewBoxBuilder<Viewbox>()
let border = Border.BorderBuilder<Border>()
let acrylicBorder = AcrylicBorder.AcrylicBorderBuilder<ExperimentalAcrylicBorder>()

let listBox = ListBox.ListBoxBuilder<ListBox>()
let listBoxItem = ListBoxItem.ListBoxItemBuilder<ListBoxItem>()
let tabStrip = TabStrip.TabStripBuilder<TabStrip>()
let tabStripItem = TabStripItem.TabStripItemBuilder<TabStripItem>()
let comboBox = ComboBox.ComboBoxBuilder<ComboBox>()
let comboBoxItem = ComboBoxItem.ComboBoxItemBuilder<ComboBoxItem>()
let carousel = Carousel.CarouselBuilder<Carousel>()
let tabControl = TabControl.TabControlBuilder<TabControl>()
let tabItem = TabItem.TabItemBuilder<TabItem>()
let treeView = TreeView.TreeViewBuilder<TreeView>()
let treeViewItem = TreeViewItem.TreeViewItemBuilder<TreeViewItem>()
let menu = Menu.MenuBuilder<Menu>()
let menuItem = MenuItem.MenuItemBuilder<MenuItem>()
let contextMenu = ContextMenu.ContextMenuBuilder<ContextMenu>()

let slider = Slider.SliderBuilder<Slider>()
let progressBar = ProgressBar.ProgressBarBuilder<ProgressBar>()

let calendar = Calendar.CalendarBuilder<Calendar>()
let calendarInput = CalendarDatePicker.CalendarDatePickerBuilder<CalendarDatePicker>()

let dateInput = DatePicker.DatePickerBuilder<DatePicker>()
let timeInput = TimePicker.TimePickerBuilder<TimePicker>()
let tickBar = TickBar.TickBarBuilder<TickBar>()
let autoComplete = AutoCompleteBox.AutoCompleteBoxBuilder<AutoCompleteBox>()
let button = Button.ButtonBuilder<Button>()
let toggleButton = ToggleButton.ToggleButtonBuilder<ToggleButton>()
let switch = ToggleSwitch.ToggleSwitchBuilder<ToggleSwitch>()
let spinner = Spinner.SpinnerBuilder<Spinner>()
let buttonSpinner = ButtonSpinner.ButtonSpinnerBuilder<ButtonSpinner>()
let numberInput = NumericUpDown.NumericUpDownBuilder<NumericUpDown>()
let checkBox = CheckBox.CheckBoxBuilder<CheckBox>()
let image = Image.ImageBuilder<Image>()
let gridSplitter = GridSplitter.GridSplitterBuilder<GridSplitter>()
let radioButton = RadioButton.RadioButtonBuilder<RadioButton>()
let repeatButton = RepeatButton.RepeatButtonBuilder<RepeatButton>()
let scrollView = ScrollViewer.ScrollViewerBuilder<ScrollViewer>()
let separator = Separator.SeparatorBuilder<Separator>()
let splitView = SplitView.SplitViewBuilder<SplitView>()
let expand = Expander.ExpanderBuilder<Expander>()
let label = TextBlock.TextBlockBuilder<TextBlock>()
let textInput = TextBox.TextBoxBuilder<TextBox>()
let accessText = AccessText.AccessTextBuilder<AccessText>()
let toolTip = ToolTip.ToolTipBuilder<ToolTip>()

let chart = Microcharts.Chart.ChartBuilder<Microcharts.ChartView.ChartView>()
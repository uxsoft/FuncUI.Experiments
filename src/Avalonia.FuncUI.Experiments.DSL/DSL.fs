module Avalonia.FuncUI.Experiments.DSL.DSL

open Avalonia.Controls
open Avalonia.Controls.Primitives
open Avalonia.Controls.Shapes

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

let button = Button.ButtonBuilder<Button>()

let textBlock = TextBlock.TextBlockBuilder<TextBlock>()
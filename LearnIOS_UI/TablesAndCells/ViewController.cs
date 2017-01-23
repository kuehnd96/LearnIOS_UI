using System;
using System.Collections.Generic;
using TablesAndCells.Data;
using TablesAndCells.TableSources;
using UIKit;

namespace TablesAndCells
{
    public partial class ViewController : UIViewController
    {
        List<GroceryItem> _foodList = new List<GroceryItem>(4);

        public ViewController(IntPtr handle) : base(handle)
        {
            _foodList.Add(new GroceryItem("Milk", 3.29, "Dairy"));
            _foodList.Add(new GroceryItem("Greek Yogurt", 5.10, "Dairy"));
            _foodList.Add(new GroceryItem("Bananas", 1.03, "Produce"));
            _foodList.Add(new GroceryItem("Strawberries", 4.99, "Produce"));
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            table = new UITableView(View.Bounds); // defaults to Plain style
            table.Source = new GroceryList(_foodList);
            Add(table);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
using System;
using System.Collections.Generic;
using UIKit;
using TablesAndCells.Data;
using Foundation;

namespace TablesAndCells.TableSources
{
    public sealed class GroceryList : UITableViewSource
    {
        const string CellIdentifier = "TableCell";

        List<GroceryItem> _foodItems;

        public GroceryList(IEnumerable<GroceryItem> foodItems)
        {
            _foodItems = new List<GroceryItem>(foodItems);
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _foodItems.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            var item = _foodItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            }

            cell.TextLabel.Text = item.Name;

            return cell;
        }
    }
}
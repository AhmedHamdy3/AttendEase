using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.Layout.Borders.Border;

namespace AttendEase.Presentation.CustomControls
{
    public class CustomTable
    {
        public Panel tablePanel;
        private int width;
        public CustomTable(int width, int height, int xDim, int yDim)
        {
            this.width = width;
            tablePanel = new Panel();
            tablePanel.Size = new Size(width, height);
            tablePanel.Location = new Point(xDim, yDim);
            tablePanel.AutoScroll = true; // Enable scrolling if the table is large
            tablePanel.BackColor = Color.White;
        }

        public void fillTable<T>(List<T> data, string[] headers, string guide, Action<DateTime, DateTime> foo1, Action<int> foo2)
        {
            //MessageBox.Show("Table Fill");
            int cellWidth = this.width / headers.Length; ; // Width of each cell
            int cellHeight = 50; // Height of each cell

            // Clear existing controls in the table panel
            tablePanel.Controls.Clear();

            // Add column headers
            Panel rowHeader = new Panel();
            rowHeader.Size = new Size(this.width, cellHeight);
            rowHeader.Location = new Point(0, 0);
            for (int col = 0; col < headers.Length; col++)
            {
                Panel headerPanel = new Panel();
                headerPanel.Size = new Size(cellWidth, cellHeight);
                headerPanel.Location = new Point(col * cellWidth, 0);
                headerPanel.BackColor = Color.White; // Header background color

                Label headerLabel = new Label();
                headerLabel.Text = headers[col];
                headerLabel.AutoSize = true;
                headerLabel.Location = new Point(10, 15); // Adjust position as needed
                headerLabel.Font = new Font("Segeo UI", 10, FontStyle.Bold); // Set font to Arial, size 9, and bold
                headerLabel.ForeColor = ColorTranslator.FromHtml("#B5B7C0");


                headerPanel.Controls.Add(headerLabel);

                rowHeader.Controls.Add(headerPanel);
            }
            tablePanel.Controls.Add(rowHeader);


            // Fill the table with data
            for (int row = 0; row < data.Count; row++)
            {
                var item = data[row];
                var properties = typeof(T).GetProperties(); // Get properties of the class

                var employeeName = properties.FirstOrDefault(p => p.Name == "Name"); // ******************
                var startDate = properties.FirstOrDefault(p => p.Name == "StartDate"); // ******************
                var endDate = properties.FirstOrDefault(p => p.Name == "EndDate"); // ******************
                var id = properties.FirstOrDefault(p => p.Name == "Id"); // ******************


                Panel rowData = new Panel();
                rowData.Size = new Size(this.width, cellHeight);
                rowData.Location = new Point(0, ((row + 1) * cellHeight));
                for (int col = 0; col < headers.Length; col++)
                {
                    // Create a panel for each cell
                    Panel cellPanel = new Panel();
                    cellPanel.Size = new Size(cellWidth, cellHeight);
                    cellPanel.Location = new Point(col * cellWidth, 0); // +1 to account for headers


                    // Add a label to the panel (for example content)
                    Label cellLabel = new Label();
                    var cellValue = properties[col].GetValue(item);


                    // Show the Date only
                    if (cellValue is DateTime)
                    {
                        cellLabel.Text = ((DateTime)cellValue).ToShortDateString() ?? "-"; ; // Get property 
                    }
                    else if (cellValue is Double && guide == "FrequentAbsences")
                    {
                        cellLabel.Text = cellValue.ToString() + "%";
                    }
                    else
                    {
                        cellLabel.Text = cellValue?.ToString() ?? "-"; // Get property value
                    }

                    cellLabel.AutoSize = true;
                    cellLabel.Location = new Point(10, 15); // Adjust position as needed
                    cellLabel.ForeColor = Color.FromArgb(10, 22, 41);
                    cellPanel.Controls.Add(cellLabel);

                    if (guide != "")
                    {
                        cellPanel.Cursor = Cursors.Hand;
                        cellLabel.Cursor = Cursors.Hand;

                        if (guide == "Arrivals" || guide == "FrequentAbsences")
                        {
                            cellPanel.MouseUp += (sender, e) =>
                            {
                                foo2((int)id.GetValue(item));
                            };

                            cellLabel.MouseUp += (sender, e) =>
                            {
                                foo2((int)id.GetValue(item));
                            };
                        }
                        else if (guide == "Day" || guide == "Period")
                        {
                            cellPanel.MouseUp += (sender, e) =>
                            {
                                foo1((DateTime)startDate.GetValue(item), (DateTime)endDate.GetValue(item));
                            };

                            cellLabel.MouseUp += (sender, e) =>
                            {
                                foo1((DateTime)startDate.GetValue(item), (DateTime)endDate.GetValue(item));
                            };
                        }
                    }

                    // Add the cell panel to the table panel
                    rowData.Controls.Add(cellPanel);
                }

                // Alternate row colors
                if (row % 2 != 0)
                {
                    rowData.BackColor = Color.White; // Odd rows
                }
                else
                {
                    rowData.BackColor = ColorTranslator.FromHtml("#E7EEFA"); // R=200, G=100, B=255; // Even rows
                }

                tablePanel.Controls.Add(rowData);
            }
        }

        public void fillTableV2<T>(List<T> data, string[] headers, Action<int> onRowClick)
        {

            int columnCount = headers.Length;
            int cellWidth = this.width / columnCount;
            int cellHeight = 50;

            tablePanel.Controls.Clear();
            tablePanel.AutoScroll = true;

            Panel rowHeader = new Panel
            {
                Size = new Size(this.width, cellHeight),
                Location = new Point(0, 0),
                BackColor = Color.White
            };

            for (int col = 0; col < columnCount; col++)
            {
                Panel headerPanel = new Panel
                {
                    Size = new Size(cellWidth, cellHeight),
                    Location = new Point(col * cellWidth, 0),
                    BorderStyle = BorderStyle.None
                };

                Label headerLabel = new Label
                {
                    Text = headers[col],
                    Size = new Size(cellWidth, cellHeight),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#B5B7C0"),
                    Dock = DockStyle.Fill
                };

                headerPanel.Controls.Add(headerLabel);
                rowHeader.Controls.Add(headerPanel);
            }

            tablePanel.Controls.Add(rowHeader);

            for (int row = 0; row < data.Count; row++)
            {
                var item = data[row];
                var properties = typeof(T).GetProperties().ToDictionary(p => p.Name, p => p);

                int idValue = -1;
                if (properties.ContainsKey("EmployeeId"))
                {
                    idValue = (int)properties["EmployeeId"].GetValue(item);
                }

                Panel rowData = new Panel
                {
                    Size = new Size(this.width, cellHeight),
                    Location = new Point(0, (row + 1) * cellHeight),
                    BackColor = (row % 2 == 0) ? ColorTranslator.FromHtml("#E7EEFA") : Color.White,
                    Cursor = Cursors.Hand,
                    Tag = idValue
                };

                rowData.Click += (sender, e) =>
                {
                    onRowClick?.Invoke(idValue);
                };

                for (int col = 0; col < columnCount; col++)
                {
                    Panel cellPanel = new Panel
                    {
                        Size = new Size(cellWidth, cellHeight),
                        Location = new Point(col * cellWidth, 0),
                        BorderStyle = BorderStyle.None
                    };

                    Label cellLabel = new Label
                    {
                        Size = new Size(cellWidth, cellHeight),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        ForeColor = Color.FromArgb(10, 22, 41),
                        Cursor = Cursors.Hand
                    };

                    if (properties.ContainsKey(headers[col]))
                    {
                        var cellValue = properties[headers[col]].GetValue(item);
                        if (cellValue is DateTime dateValue)
                        {
                            cellLabel.Text = dateValue.ToShortDateString();
                        }
                        else
                        {
                            cellLabel.Text = cellValue?.ToString() ?? "-";
                        }
                    }
                    else
                    {
                        cellLabel.Text = "-";
                    }

                    cellLabel.Click += (sender, e) =>
                    {
                        onRowClick?.Invoke(idValue);
                    };

                    cellPanel.Controls.Add(cellLabel);
                    rowData.Controls.Add(cellPanel);
                }

                tablePanel.Controls.Add(rowData);
            }
        }
        public void fillTableV3<T>(List<T> data, string[] headers, string guide, Action<int> onRowClick)
        {
            //MessageBox.Show("Table Fill");
            int cellWidth = this.width / headers.Length; ; // Width of each cell
            int cellHeight = 50; // Height of each cell

            // Clear existing controls in the table panel
            tablePanel.Controls.Clear();

            // Add column headers
            Panel rowHeader = new Panel();
            rowHeader.Size = new Size(this.width, cellHeight);
            rowHeader.Location = new Point(0, 0);
            for (int col = 0; col < headers.Length; col++)
            {
                Panel headerPanel = new Panel();
                headerPanel.Size = new Size(cellWidth, cellHeight);
                headerPanel.Location = new Point(col * cellWidth, 0);
                headerPanel.BackColor = Color.White; // Header background color

                Label headerLabel = new Label();
                headerLabel.Text = headers[col];
                headerLabel.AutoSize = true;
                headerLabel.Location = new Point(10, 15); // Adjust position as needed
                headerLabel.Font = new Font("Segeo UI", 10, FontStyle.Bold); // Set font to Arial, size 9, and bold
                headerLabel.ForeColor = ColorTranslator.FromHtml("#B5B7C0");


                headerPanel.Controls.Add(headerLabel);

                rowHeader.Controls.Add(headerPanel);
            }
            tablePanel.Controls.Add(rowHeader);


            // Fill the table with data
            for (int row = 0; row < data.Count; row++)
            {
                var item = data[row];
                var properties = typeof(T).GetProperties(); // Get properties of the class

                var id = properties.FirstOrDefault(p => p.Name == "EmployeeId"); // ******************
                var scheduleId = properties.FirstOrDefault(p => p.Name == "Id");

                Panel rowData = new Panel();
                rowData.Size = new Size(this.width, cellHeight);
                rowData.Location = new Point(0, ((row + 1) * cellHeight));
                for (int col = 0; col < headers.Length; col++)
                {
                    // Create a panel for each cell
                    Panel cellPanel = new Panel();
                    cellPanel.Size = new Size(cellWidth, cellHeight);
                    cellPanel.Location = new Point(col * cellWidth, 0); // +1 to account for headers


                    // Add a label to the panel (for example content)
                    Label cellLabel = new Label();

                    cellLabel.Text = properties[col].GetValue(item)?.ToString() ?? "-"; // Get property value                    

                    cellLabel.AutoSize = true;
                    cellLabel.Location = new Point(10, 15); // Adjust position as needed
                    cellLabel.ForeColor = Color.FromArgb(10, 22, 41);
                    cellPanel.Controls.Add(cellLabel);


                    cellPanel.Cursor = Cursors.Hand;
                    cellLabel.Cursor = Cursors.Hand;


                    if(guide == "Employees")
                    {
                        cellPanel.MouseUp += (sender, e) =>
                        {
                            onRowClick((int)id.GetValue(item));
                        };

                        cellLabel.MouseUp += (sender, e) =>
                        {
                            onRowClick((int)id.GetValue(item));
                        };
                    }
                    else if(guide == "Schedules")
                    {
                        cellPanel.MouseUp += (sender, e) =>
                        {
                            onRowClick((int)scheduleId.GetValue(item));
                        };

                        cellLabel.MouseUp += (sender, e) =>
                        {
                            onRowClick((int)scheduleId.GetValue(item));
                        };
                    }
                    // Add the cell panel to the table panel
                    rowData.Controls.Add(cellPanel);
                }

                // Alternate row colors
                if (row % 2 != 0)
                {
                    rowData.BackColor = Color.White; // Odd rows
                }
                else
                {
                    rowData.BackColor = ColorTranslator.FromHtml("#E7EEFA"); // R=200, G=100, B=255; // Even rows
                }

                tablePanel.Controls.Add(rowData);
            }
        }
    }
}

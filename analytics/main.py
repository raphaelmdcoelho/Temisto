import pandas as pd
import xlsxwriter

df = pd.read_excel (r'./../documents/heroes_v1.xlsx', engine='openpyxl')

## chart

workbook = xlsxwriter.Workbook('chart.xlsx')

worksheet = workbook.add_worksheet()
worksheet.write(1, 0, 'Total')

chart = workbook.add_chart({'type': 'column'})

# Configure the series of the chart from the dataframe data.
chart.add_series({
   'values':     '=Sheet1!$B$2:$B$8',
   'gap':        2,
})

# Configure the chart axes.
chart.set_y_axis({'major_gridlines': {'visible': False}})

# Turn off chart legend. It is on by default in Excel.
chart.set_legend({'position': 'none'})

workbook.close()

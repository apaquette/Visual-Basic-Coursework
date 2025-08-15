<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMABooksDataSet = New CustomerInvoiceDisplay.MMABooksDataSet()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesDataGridView = New System.Windows.Forms.DataGridView()
        Me.InvoiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesTaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShippingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByCustomerIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCustomerIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.TableAdapterManager()
        Me.CustomersTableAdapter = New CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.CustomersTableAdapter()
        Me.InvoicesTableAdapter = New CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.InvoicesTableAdapter()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCustomerIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(16, 53)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(16, 85)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(16, 117)
        CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(104, 17)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City, State, Zip:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(129, 49)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(399, 22)
        Me.NameTextBox.TabIndex = 5
        Me.NameTextBox.TabStop = False
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.MMABooksDataSet
        '
        'MMABooksDataSet
        '
        Me.MMABooksDataSet.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(129, 81)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(399, 22)
        Me.AddressTextBox.TabIndex = 7
        Me.AddressTextBox.TabStop = False
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(129, 113)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(227, 22)
        Me.CityTextBox.TabIndex = 9
        Me.CityTextBox.TabStop = False
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(365, 113)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.Size = New System.Drawing.Size(44, 22)
        Me.StateTextBox.TabIndex = 11
        Me.StateTextBox.TabStop = False
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(419, 113)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.ReadOnly = True
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(109, 22)
        Me.ZipCodeTextBox.TabIndex = 13
        Me.ZipCodeTextBox.TabStop = False
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "FK_Invoices_Customers"
        Me.InvoicesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'InvoicesDataGridView
        '
        Me.InvoicesDataGridView.AllowUserToAddRows = False
        Me.InvoicesDataGridView.AllowUserToDeleteRows = False
        Me.InvoicesDataGridView.AutoGenerateColumns = False
        Me.InvoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoicesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceIDDataGridViewTextBoxColumn, Me.InvoiceDateDataGridViewTextBoxColumn, Me.ProductTotalDataGridViewTextBoxColumn, Me.SalesTaxDataGridViewTextBoxColumn, Me.ShippingDataGridViewTextBoxColumn, Me.InvoiceTotalDataGridViewTextBoxColumn})
        Me.InvoicesDataGridView.DataSource = Me.InvoicesBindingSource
        Me.InvoicesDataGridView.Location = New System.Drawing.Point(20, 162)
        Me.InvoicesDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InvoicesDataGridView.Name = "InvoicesDataGridView"
        Me.InvoicesDataGridView.ReadOnly = True
        Me.InvoicesDataGridView.RowHeadersWidth = 51
        Me.InvoicesDataGridView.Size = New System.Drawing.Size(804, 271)
        Me.InvoicesDataGridView.TabIndex = 14
        '
        'InvoiceIDDataGridViewTextBoxColumn
        '
        Me.InvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID"
        Me.InvoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice ID"
        Me.InvoiceIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InvoiceIDDataGridViewTextBoxColumn.Name = "InvoiceIDDataGridViewTextBoxColumn"
        Me.InvoiceIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceIDDataGridViewTextBoxColumn.Width = 80
        '
        'InvoiceDateDataGridViewTextBoxColumn
        '
        Me.InvoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate"
        DataGridViewCellStyle21.Format = "d"
        Me.InvoiceDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.InvoiceDateDataGridViewTextBoxColumn.HeaderText = "Invoice Date"
        Me.InvoiceDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InvoiceDateDataGridViewTextBoxColumn.Name = "InvoiceDateDataGridViewTextBoxColumn"
        Me.InvoiceDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceDateDataGridViewTextBoxColumn.Width = 125
        '
        'ProductTotalDataGridViewTextBoxColumn
        '
        Me.ProductTotalDataGridViewTextBoxColumn.DataPropertyName = "ProductTotal"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.ProductTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.ProductTotalDataGridViewTextBoxColumn.HeaderText = "Product Total"
        Me.ProductTotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductTotalDataGridViewTextBoxColumn.Name = "ProductTotalDataGridViewTextBoxColumn"
        Me.ProductTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductTotalDataGridViewTextBoxColumn.Width = 125
        '
        'SalesTaxDataGridViewTextBoxColumn
        '
        Me.SalesTaxDataGridViewTextBoxColumn.DataPropertyName = "SalesTax"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        Me.SalesTaxDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.SalesTaxDataGridViewTextBoxColumn.HeaderText = "Sales Tax"
        Me.SalesTaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalesTaxDataGridViewTextBoxColumn.Name = "SalesTaxDataGridViewTextBoxColumn"
        Me.SalesTaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalesTaxDataGridViewTextBoxColumn.Width = 80
        '
        'ShippingDataGridViewTextBoxColumn
        '
        Me.ShippingDataGridViewTextBoxColumn.DataPropertyName = "Shipping"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N2"
        Me.ShippingDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.ShippingDataGridViewTextBoxColumn.HeaderText = "Shipping"
        Me.ShippingDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ShippingDataGridViewTextBoxColumn.Name = "ShippingDataGridViewTextBoxColumn"
        Me.ShippingDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShippingDataGridViewTextBoxColumn.Width = 80
        '
        'InvoiceTotalDataGridViewTextBoxColumn
        '
        Me.InvoiceTotalDataGridViewTextBoxColumn.DataPropertyName = "InvoiceTotal"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "N2"
        Me.InvoiceTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.InvoiceTotalDataGridViewTextBoxColumn.HeaderText = "Invoice Total"
        Me.InvoiceTotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InvoiceTotalDataGridViewTextBoxColumn.Name = "InvoiceTotalDataGridViewTextBoxColumn"
        Me.InvoiceTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceTotalDataGridViewTextBoxColumn.Width = 125
        '
        'FillByCustomerIDToolStrip
        '
        Me.FillByCustomerIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByCustomerIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerIDToolStripLabel, Me.CustomerIDToolStripTextBox, Me.FillByCustomerIDToolStripButton})
        Me.FillByCustomerIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByCustomerIDToolStrip.Name = "FillByCustomerIDToolStrip"
        Me.FillByCustomerIDToolStrip.Size = New System.Drawing.Size(851, 27)
        Me.FillByCustomerIDToolStrip.TabIndex = 15
        Me.FillByCustomerIDToolStrip.Text = "FillByCustomerIDToolStrip"
        '
        'CustomerIDToolStripLabel
        '
        Me.CustomerIDToolStripLabel.Name = "CustomerIDToolStripLabel"
        Me.CustomerIDToolStripLabel.Size = New System.Drawing.Size(94, 24)
        Me.CustomerIDToolStripLabel.Text = "Customer ID:"
        '
        'CustomerIDToolStripTextBox
        '
        Me.CustomerIDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CustomerIDToolStripTextBox.Name = "CustomerIDToolStripTextBox"
        Me.CustomerIDToolStripTextBox.Size = New System.Drawing.Size(65, 27)
        '
        'FillByCustomerIDToolStripButton
        '
        Me.FillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByCustomerIDToolStripButton.Name = "FillByCustomerIDToolStripButton"
        Me.FillByCustomerIDToolStripButton.Size = New System.Drawing.Size(103, 24)
        Me.FillByCustomerIDToolStripButton.Text = "Get Customer"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate"
        DataGridViewCellStyle26.Format = "d"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn3.HeaderText = "Invoice Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductTotal"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "C2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product Total"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SalesTax"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "C2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sales Tax"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Shipping"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "C2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn6.HeaderText = "Shipping"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "InvoiceTotal"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "C2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn7.HeaderText = "Invoice Total"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.UpdateOrder = CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 458)
        Me.Controls.Add(Me.FillByCustomerIDToolStrip)
        Me.Controls.Add(Me.InvoicesDataGridView)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Invoices"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCustomerIDToolStrip.ResumeLayout(False)
        Me.FillByCustomerIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMABooksDataSet As CustomerInvoiceDisplay.MMABooksDataSet
    Friend WithEvents TableAdapterManager As CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersTableAdapter As CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvoicesTableAdapter As CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FillByCustomerIDToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CustomerIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CustomerIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByCustomerIDToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesTaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShippingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

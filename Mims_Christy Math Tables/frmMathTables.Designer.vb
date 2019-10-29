<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathTables
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
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTrigTable = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.btnTableofSquares = New System.Windows.Forms.Button()
        Me.btnTableofCubes = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(219, 52)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 0
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(219, 104)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Starting Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ending Value:"
        '
        'btnTrigTable
        '
        Me.btnTrigTable.Location = New System.Drawing.Point(71, 176)
        Me.btnTrigTable.Name = "btnTrigTable"
        Me.btnTrigTable.Size = New System.Drawing.Size(98, 55)
        Me.btnTrigTable.TabIndex = 4
        Me.btnTrigTable.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trig Table"
        Me.btnTrigTable.UseVisualStyleBackColor = True
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.Location = New System.Drawing.Point(258, 176)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(98, 55)
        Me.btnSquareRoot.TabIndex = 5
        Me.btnSquareRoot.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Square Root" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Table"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'btnTableofSquares
        '
        Me.btnTableofSquares.Location = New System.Drawing.Point(445, 176)
        Me.btnTableofSquares.Name = "btnTableofSquares"
        Me.btnTableofSquares.Size = New System.Drawing.Size(98, 55)
        Me.btnTableofSquares.TabIndex = 6
        Me.btnTableofSquares.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Table of Squares"
        Me.btnTableofSquares.UseVisualStyleBackColor = True
        '
        'btnTableofCubes
        '
        Me.btnTableofCubes.Location = New System.Drawing.Point(632, 176)
        Me.btnTableofCubes.Name = "btnTableofCubes"
        Me.btnTableofCubes.Size = New System.Drawing.Size(98, 55)
        Me.btnTableofCubes.TabIndex = 7
        Me.btnTableofCubes.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Table of Cubes"
        Me.btnTableofCubes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSquareRoot)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnTableofCubes)
        Me.GroupBox1.Controls.Add(Me.btnTrigTable)
        Me.GroupBox1.Controls.Add(Me.btnTableofSquares)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 256)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 14
        Me.lstResults.Location = New System.Drawing.Point(28, 311)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(812, 242)
        Me.lstResults.TabIndex = 9
        '
        'frmMathTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 598)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMathTables"
        Me.Text = "Math Tables"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTrigTable As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents btnTableofSquares As Button
    Friend WithEvents btnTableofCubes As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstResults As ListBox
End Class

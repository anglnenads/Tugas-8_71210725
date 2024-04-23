<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        Me.lblNoPlat = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNoPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColExpired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoPlat
        '
        Me.lblNoPlat.AutoSize = True
        Me.lblNoPlat.Location = New System.Drawing.Point(12, 42)
        Me.lblNoPlat.Name = "lblNoPlat"
        Me.lblNoPlat.Size = New System.Drawing.Size(64, 20)
        Me.lblNoPlat.TabIndex = 1
        Me.lblNoPlat.Text = "No. Plat"
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(12, 136)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(48, 20)
        Me.lblBiaya.TabIndex = 2
        Me.lblBiaya.Text = "Biaya"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(12, 188)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(62, 20)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "Expired"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(414, 37)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(23, 20)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "Id"
        Me.lblId.Visible = False
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(346, 84)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(46, 20)
        Me.lblJenis.TabIndex = 5
        Me.lblJenis.Text = "Jenis"
        '
        'txtNoPlat
        '
        Me.txtNoPlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPlat.Location = New System.Drawing.Point(104, 34)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(268, 26)
        Me.txtNoPlat.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Location = New System.Drawing.Point(104, 82)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(190, 26)
        Me.txtNama.TabIndex = 7
        '
        'txtBiaya
        '
        Me.txtBiaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBiaya.Location = New System.Drawing.Point(104, 134)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(190, 26)
        Me.txtBiaya.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 181)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(190, 26)
        Me.DateTimePicker1.TabIndex = 10
        '
        'cmbJenis
        '
        Me.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        Me.cmbJenis.Location = New System.Drawing.Point(418, 80)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(121, 28)
        Me.cmbJenis.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kendaraan terdaftar langganan :"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.ColNoPlat, Me.ColNama, Me.colJenis, Me.ColExpired, Me.colBiaya})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(776, 192)
        Me.DataGridView1.TabIndex = 13
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'ColNoPlat
        '
        Me.ColNoPlat.HeaderText = "No Plat"
        Me.ColNoPlat.MinimumWidth = 8
        Me.ColNoPlat.Name = "ColNoPlat"
        Me.ColNoPlat.Width = 150
        '
        'ColNama
        '
        Me.ColNama.HeaderText = "Nama Pemilik"
        Me.ColNama.MinimumWidth = 8
        Me.ColNama.Name = "ColNama"
        Me.ColNama.Width = 150
        '
        'colJenis
        '
        Me.colJenis.HeaderText = "Jenis"
        Me.colJenis.MinimumWidth = 8
        Me.colJenis.Name = "colJenis"
        Me.colJenis.Width = 150
        '
        'ColExpired
        '
        Me.ColExpired.HeaderText = "Expired"
        Me.ColExpired.MinimumWidth = 8
        Me.ColExpired.Name = "ColExpired"
        Me.ColExpired.Width = 150
        '
        'colBiaya
        '
        Me.colBiaya.HeaderText = "Biaya"
        Me.colBiaya.MinimumWidth = 8
        Me.colBiaya.Name = "colBiaya"
        Me.colBiaya.Width = 150
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(401, 181)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(92, 33)
        Me.btnTambah.TabIndex = 14
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(499, 181)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 33)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(600, 181)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(91, 33)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(12, 90)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 18
        Me.lblNama.Text = "Nama"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(697, 181)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 33)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(697, 454)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(91, 33)
        Me.btnTutup.TabIndex = 20
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        Me.btnTutup.Visible = False
        '
        'frmLangganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.lblNoPlat)
        Me.KeyPreview = True
        Me.Name = "frmLangganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Kendaraan Langganan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColNama As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents ColExpired As DataGridViewTextBoxColumn
    Friend WithEvents colBiaya As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTutup As Button
End Class

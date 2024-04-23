<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanggananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.lblInputPlat = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColNoPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPlat = New System.Windows.Forms.Panel()
        Me.pnlHarga = New System.Windows.Forms.Panel()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblInfoJenis = New System.Windows.Forms.Label()
        Me.lblTekan = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblInfoUser = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblJmlKendaraan = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlPlat.SuspendLayout()
        Me.pnlHarga.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AturToolStripMenuItem, Me.ProfilToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'AturToolStripMenuItem
        '
        Me.AturToolStripMenuItem.Name = "AturToolStripMenuItem"
        Me.AturToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.AturToolStripMenuItem.Text = "Atur"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanggananToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LanggananToolStripMenuItem
        '
        Me.LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        Me.LanggananToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.LanggananToolStripMenuItem.Text = "Kendaraan Langganan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem1, Me.TentangToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'BantuanToolStripMenuItem1
        '
        Me.BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(178, 34)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(178, 34)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 29)
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.BackColor = System.Drawing.Color.Transparent
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(433, 9)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(370, 78)
        Me.lblPlat.TabIndex = 1
        Me.lblPlat.Text = "R 6872 ZH"
        Me.lblPlat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInputPlat
        '
        Me.lblInputPlat.AutoSize = True
        Me.lblInputPlat.Location = New System.Drawing.Point(13, 19)
        Me.lblInputPlat.Name = "lblInputPlat"
        Me.lblInputPlat.Size = New System.Drawing.Size(77, 20)
        Me.lblInputPlat.TabIndex = 2
        Me.lblInputPlat.Text = "Input Plat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(423, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Kendaraan sedang Parkir"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.BackColor = System.Drawing.Color.Transparent
        Me.lblHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(17, 10)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(102, 52)
        Me.lblHarga.TabIndex = 6
        Me.lblHarga.Text = "Rp. "
        '
        'txtNoPlat
        '
        Me.txtNoPlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPlat.Location = New System.Drawing.Point(144, 269)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(146, 26)
        Me.txtNoPlat.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNoPlat, Me.ColMasuk, Me.ColKeluar, Me.ColHarga, Me.ColJenis, Me.Id})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(423, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(816, 287)
        Me.DataGridView1.TabIndex = 12
        '
        'ColNoPlat
        '
        Me.ColNoPlat.HeaderText = "No Plat"
        Me.ColNoPlat.MinimumWidth = 8
        Me.ColNoPlat.Name = "ColNoPlat"
        Me.ColNoPlat.Width = 150
        '
        'ColMasuk
        '
        Me.ColMasuk.HeaderText = "Masuk"
        Me.ColMasuk.MinimumWidth = 8
        Me.ColMasuk.Name = "ColMasuk"
        Me.ColMasuk.Width = 150
        '
        'ColKeluar
        '
        Me.ColKeluar.HeaderText = "Keluar"
        Me.ColKeluar.MinimumWidth = 8
        Me.ColKeluar.Name = "ColKeluar"
        Me.ColKeluar.Width = 150
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.MinimumWidth = 8
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.Width = 150
        '
        'ColJenis
        '
        Me.ColJenis.HeaderText = "Jenis"
        Me.ColJenis.MinimumWidth = 8
        Me.ColJenis.Name = "ColJenis"
        Me.ColJenis.Width = 150
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 8
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 36)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pnlPlat
        '
        Me.pnlPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPlat.Controls.Add(Me.lblPlat)
        Me.pnlPlat.Location = New System.Drawing.Point(24, 48)
        Me.pnlPlat.Name = "pnlPlat"
        Me.pnlPlat.Size = New System.Drawing.Size(1203, 100)
        Me.pnlPlat.TabIndex = 20
        '
        'pnlHarga
        '
        Me.pnlHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHarga.Controls.Add(Me.lblHarga)
        Me.pnlHarga.Location = New System.Drawing.Point(24, 154)
        Me.pnlHarga.Name = "pnlHarga"
        Me.pnlHarga.Size = New System.Drawing.Size(393, 78)
        Me.pnlHarga.TabIndex = 21
        '
        'pnlInput
        '
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.lblInfoJenis)
        Me.pnlInput.Controls.Add(Me.lblTekan)
        Me.pnlInput.Controls.Add(Me.lblJenis)
        Me.pnlInput.Controls.Add(Me.lblInputPlat)
        Me.pnlInput.Location = New System.Drawing.Point(24, 254)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(393, 106)
        Me.pnlInput.TabIndex = 22
        '
        'lblInfoJenis
        '
        Me.lblInfoJenis.AutoSize = True
        Me.lblInfoJenis.Location = New System.Drawing.Point(270, 19)
        Me.lblInfoJenis.Name = "lblInfoJenis"
        Me.lblInfoJenis.Size = New System.Drawing.Size(0, 20)
        Me.lblInfoJenis.TabIndex = 25
        '
        'lblTekan
        '
        Me.lblTekan.AutoSize = True
        Me.lblTekan.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTekan.Location = New System.Drawing.Point(14, 77)
        Me.lblTekan.Name = "lblTekan"
        Me.lblTekan.Size = New System.Drawing.Size(185, 15)
        Me.lblTekan.TabIndex = 24
        Me.lblTekan.Text = "Tekan Enter untuk Masuk/Keluar"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(14, 53)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(330, 15)
        Me.lblJenis.TabIndex = 23
        Me.lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        '
        'lblInfoUser
        '
        Me.lblInfoUser.AutoSize = True
        Me.lblInfoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoUser.Location = New System.Drawing.Point(20, 385)
        Me.lblInfoUser.Name = "lblInfoUser"
        Me.lblInfoUser.Size = New System.Drawing.Size(84, 20)
        Me.lblInfoUser.TabIndex = 25
        Me.lblInfoUser.Text = "Informasi"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTgl.Location = New System.Drawing.Point(30, 414)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(55, 15)
        Me.lblTgl.TabIndex = 25
        Me.lblTgl.Text = "Tanggal:"
        '
        'lblJmlKendaraan
        '
        Me.lblJmlKendaraan.AutoSize = True
        Me.lblJmlKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlKendaraan.Location = New System.Drawing.Point(30, 439)
        Me.lblJmlKendaraan.Name = "lblJmlKendaraan"
        Me.lblJmlKendaraan.Size = New System.Drawing.Size(260, 15)
        Me.lblJmlKendaraan.TabIndex = 26
        Me.lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 473)
        Me.Controls.Add(Me.lblJmlKendaraan)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.lblInfoUser)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlPlat)
        Me.Controls.Add(Me.pnlHarga)
        Me.Controls.Add(Me.pnlInput)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parkir System v.1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlPlat.ResumeLayout(False)
        Me.pnlPlat.PerformLayout()
        Me.pnlHarga.ResumeLayout(False)
        Me.pnlHarga.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
End Class

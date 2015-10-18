Public Class Form1

    Private Sub AplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiToolStripMenuItem.Click

    End Sub

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Bintang.MdiParent = Me
        Bintang.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Matrik.MdiParent = Me
        Matrik.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub
End Class

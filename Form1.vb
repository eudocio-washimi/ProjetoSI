Public Class Form1
    Private Sub AdivinharNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdivinharNúmeroToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Batch\teste.bat")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Try
            frm_cadastro.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class

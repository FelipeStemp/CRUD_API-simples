using consumindoAPISimples.UserServices;
using ConsumindoAPISimples.entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace consumindoAPISimples
{
    public partial class Form1 : Form
    {
        getUser userS = new getUser();
        PostUser userPost = new PostUser();
        putUser userPut = new putUser();
        deleteUser userDelete = new deleteUser();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var email = txtEmail.Text;
                var userObj = await userS.GetByEmail(email);

                if (userObj == null)
                {
                    MessageBox.Show("Email não localizado");
                }
                else
                {
                    txtID.Text = userObj._id;
                    txtUserName.Text = userObj.username;
                    txtEmail.Text = userObj.email;

                    if (userObj.idade == 0)
                    {
                        txtIdade.Text = "Não informado";
                    }
                    else
                    {
                        txtIdade.Text = userObj.idade.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o usuário: {ex.Message}");
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var email = txtEmail.Text;
                var userObj = await userS.GetByEmailwithPass(email);

                if (userObj == null)
                {
                    MessageBox.Show("Email não localizado");
                }
                else
                {
                    txtID.Text = userObj._id;
                    txtUserName.Text = userObj.username;
                    txtEmail.Text = userObj.email;
                    txtPassword.Text = userObj.authentication.password;

                    if (userObj.idade == 0)
                    {
                        txtIdade.Text = "Não informado";
                    }
                    else
                    {
                        txtIdade.Text = userObj.idade.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o usuário: {ex.Message}");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var Email = txtEmail.Text;
                var Username = txtUserName.Text;
                var Password = txtPassword.Text;
                int Idade;

                if (int.TryParse(txtIdade.Text, out int idadeValue))
                {
                    Idade = idadeValue;
                }
                else
                {
                    Idade = 0;
                }

                var newUser = new ConsumindoAPISimples.entities.User
                {
                    username = Username,
                    email = Email,
                    idade = Idade,
                    password = Password

                };

                var createdUser = await userPost.PostCreateUser(newUser);

                MessageBox.Show("Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar usuário: {ex.Message}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtIdade.Clear();
            txtID.Clear();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = txtID.Text;
                var email = txtEmail.Text;
                var username = txtUserName.Text;
                var password = txtPassword.Text;
                int idade;

                if (int.TryParse(txtIdade.Text, out int idadeValue))
                {
                    idade = idadeValue;
                }
                else
                {
                    idade = 0;
                }
                var updatedUser = new ConsumindoAPISimples.entities.User
                {
                    username = username,
                    email = email,
                    idade = idade

                };

                var result = await userPut.PutUpdateUser(updatedUser, userId);

                MessageBox.Show("Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}");
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = txtID.Text;
                var newPassword = txtPassword.Text;

                await userPut.PutUpdateUserPassword(newPassword, userId);

                MessageBox.Show("Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}");
            }

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var email = txtEmail.Text;

                await userDelete.DeleteUser(email);

                MessageBox.Show("Usuário deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar usuário: {ex.Message}");
            }
        }
    }
}

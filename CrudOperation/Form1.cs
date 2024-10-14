using CrudOperation.Context;
using CrudOperation.Models;
using CrudOperation.Repositoy;
using CrudOperation.Service;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation
{
    public partial class Form1 : Form
    {
        public readonly PersonService service;
        public readonly SubjectService subjectService;
        public Form1()
        {
            subjectService = new SubjectService(new SubjectRepository(new AppDbContext()));
            service = new PersonService(new PersonRepository(new AppDbContext()));
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        async void Subject1()
        {
            var subject = await subjectService.GetAll();
            var student = await service.GetAll();
            CBCreatePerson.DataSource = subject.ToList();
            CBUpdatePerson.DataSource = subject.ToList();
            CBUpdatePerson.DisplayMember = "subject_name";
            CBUpdatePerson.ValueMember = "id";
            CBUpdatePerson.SelectedIndex = -1;
            CBCreatePerson.DisplayMember = "subject_name";
            CBCreatePerson.ValueMember = "id";
            CBCreatePerson.SelectedIndex = -1;
            CBUpdateSelect.DataSource = student.ToList();
            CBUpdateSelect.DisplayMember = "Name";
            CBUpdateSelect.ValueMember = "id";
            CBUpdateSelect.SelectedIndex = -1;
            CBUpdateSub.DataSource = subject.ToList();
            CBUpdateSub.DisplayMember = "subject_name";
            CBUpdateSub.ValueMember = "id";
            CBUpdateSub.SelectedIndex = -1;
            CBDeletePerson.DataSource = student.ToList();
            CBDeletePerson.DisplayMember = "Name";
            CBDeletePerson.ValueMember = "id";
            CBDeletePerson.SelectedIndex = -1;
        }
        async void DELETE()
        {
            var subjects = await subjectService.GetAll();
            var persons = await service.GetAll();
            var result = subjects
            .Where(s => !persons.Any(p => p.subject_id == s.id))
            .Select(s => new { s.id, s.subject_name })
            .ToList();
            dataGridViewDeleteSub.DataSource = result;
            CBDeleteSubject.DataSource = result;
            CBDeleteSubject.DisplayMember = "subject_name";
            CBDeleteSubject.ValueMember = "id";
            CBDeleteSubject.SelectedIndex = -1;
        }
        public void Refresh()
        {
            ReadAll();
            Subject1();
            CreateSub();
            DELETE();
        }
        private async void ReadAll()
        {
            var student = await service.GetAll();
            var subject = await subjectService.GetAll();
            var res = from result in student
                      join sub in subject
                      on result.subject_id equals sub.id
                      orderby result.Id
                      select new
                      {
                          id = result.Id,
                          PersonName = result.Name,
                          SubjectName = sub.subject_name
                      };
            dataGridViewReadAll.DataSource = res.ToList();
            dataGridViewUpdatePerson.DataSource = res.ToList();
            dataGridViewCreateStud.DataSource = res.ToList();
            dataGridViewDeletePerson.DataSource = res.ToList();
        }
        private async void CreateSub()
        {
            var subject = await subjectService.GetAll();
            var res = from result in subject
                      orderby result.id
                      select new
                      {
                          id = result.id,
                          Name = result.subject_name
                      };
            dataGridViewCreateSub.DataSource = res.ToList();
            dataGridViewUpdateSub.DataSource = res.ToList();
        }
        private void dataGridViewPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void BTCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Person newparametrs = new Person()
                {
                    Name = TBCreatePerson.Text,
                    subject_id = (int)CBCreatePerson.SelectedValue
                };
                await service.Create(newparametrs);
                CBCreatePerson.SelectedIndex = -1;
                TBCreatePerson.Text = null;
                MessageBox.Show("Malumotlar qoshildi", "Close window", MessageBoxButtons.OK);
                Refresh();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }

        }
        private async void BTCreateSub_Click(object sender, EventArgs e)
        {
            try
            {
                Subject newparametrs = new Subject()
                {
                    subject_name = TBCreateSub.Text
                };
                await subjectService.CresteSub(newparametrs);
                TBCreateSub.Text = null;
                MessageBox.Show("Malumotlar qoshildi", "Close window", MessageBoxButtons.OK);
                Refresh();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }

        }
        private async void BTUpdatePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBUpdateSelect.SelectedIndex != -1)
                {
                    int a = (int)CBUpdateSelect.SelectedValue;
                    var persons = await service.GetAll();
                    Person newperson = persons.ToList().Find(c => c.Id == a);
                    if (TBUpdatePerson.Text != "")
                    {
                        newperson.Name = TBUpdatePerson.Text;
                    }
                    if (CBUpdatePerson.SelectedIndex != -1)
                    {
                        newperson.subject_id = (int)CBUpdatePerson.SelectedValue;
                    }
                    await service.Update(newperson);
                    CBUpdatePerson.SelectedIndex = -1;
                    TBUpdatePerson.Text = null;
                    CBUpdateSelect.SelectedIndex = -1;
                    MessageBox.Show("Malumotlar yangilandi", "Close window", MessageBoxButtons.OK);
                    Refresh();
                    await service.Update(newperson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void BTRefresh_Click(object sender, EventArgs e)
        {

        }
        private async void TBUpdateSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBUpdateSub.SelectedIndex != -1)
                {
                    if (TBUpdateSub.Text != "")
                    {
                        int a = (int)CBUpdateSub.SelectedValue;
                        var subjects = await subjectService.GetAll();
                        Subject subject1 = subjects.ToList().Find(c => c.id == a);
                        subject1.subject_name = TBUpdateSubject.Text;

                        TBUpdateSubject.Text = null;
                        CBUpdateSub.SelectedIndex = -1;
                        MessageBox.Show("Malumotlar Yangilandi", "Close Window", MessageBoxButtons.OK);
                        await subjectService.UpdateSub(subject1);
                        Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private async void BTDeletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBDeletePerson.SelectedIndex != -1)
                {
                    var person = await service.GetAll();
                    Person delete = person.ToList().Find(x => x.Id == (int)CBDeletePerson.SelectedValue);
                    DialogResult res = MessageBox.Show("Do you want to delete", "Close window", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        CBDeletePerson.SelectedIndex = -1;
                        MessageBox.Show("Malumotlar ochib ketti", "Close window", MessageBoxButtons.OK);
                        await service.Delete(delete);
                        Refresh();
                    }
                    else if (res == DialogResult.No)
                    {
                        CBDeletePerson.SelectedIndex = -1;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private async void BTDeleteSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBDeleteSubject.SelectedIndex != -1)
                {
                    DialogResult res = MessageBox.Show("Do you want to delete", "Close window", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Malumotlar ochib ketti", "Close window", MessageBoxButtons.OK);
                        var subject = await subjectService.GetAll();
                        int a = (int)CBDeleteSubject.SelectedValue;
                        CBDeleteSubject.SelectedIndex = -1;
                        var delsub = subject.ToList().Find(x => x.id == a);
                        await subjectService.Delete(delsub);
                        Refresh();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK);
            }
        }
    }
}

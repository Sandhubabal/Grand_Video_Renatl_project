using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand_Video_Renatl_project
{
    public partial class Form1 : Form
    {
        DatabaseFields databaseFields = new DatabaseFields();
        DatabaseInteractions databaseInteractions = new DatabaseInteractions();
        string bookCost;


        public Form1()
        {
            InitializeComponent();
        }

        // add customer 

        private void add_cust_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (full_name_customer.Text != "" && email_id_customer.Text != "" && mobile_of_customer.Text != "" && address_of_customer.Text != "")
                {
                    databaseFields.Name = full_name_customer.Text;
                    databaseFields.Email = email_id_customer.Text;
                    databaseFields.Mobile = mobile_of_customer.Text;
                    databaseFields.Address = address_of_customer.Text;

                    string qry = "Insert into Customers(Name,Email,Mobile,Address)values('" + databaseFields.Name + "','" + databaseFields.Email + "','" + databaseFields.Mobile + "','" + databaseFields.Address + "')";
                    databaseInteractions.Operations(qry);
                    address_of_customer.Text = "";
                    email_id_customer.Text = "";
                    full_name_customer.Text = "";
                    mobile_of_customer.Text = "";
                    display_message.Text = "New customer is added Successfully";
                }
            }
            catch (Exception ex)
            {
                display_message.Text = "Please check all fields are mandatory";
            }
        }

        // update cutomer 

        private void update_cust_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerid_display.Text != "" && full_name_customer.Text.ToString() != "" && email_id_customer.Text.ToString() != "" && address_of_customer.Text.ToString() != "")
                {
                    databaseFields.CustomerId = Convert.ToInt32(customerid_display.Text);
                    databaseFields.Name = full_name_customer.Text;
                    databaseFields.Email = email_id_customer.Text;
                    databaseFields.Mobile = mobile_of_customer.Text;
                    databaseFields.Address = address_of_customer.Text;

                    string qry = "Update Customers set Name='" + databaseFields.Name + "',Email='" + databaseFields.Email + "',Mobile='" + databaseFields.Mobile + "',Address='" + databaseFields.Address + "' where CustomerId=" + databaseFields.CustomerId + "";
                    databaseInteractions.Operations(qry);
                    address_of_customer.Text = "";
                    email_id_customer.Text = "";
                    full_name_customer.Text = "";
                    customerid_display.Text = "";
                    mobile_of_customer.Text = "";
                    display_message.Text = "Customer is updated successfully";
                }
            }
            catch (Exception)
            {
                display_message.Text = "Please check all fields are mandatory";
            }

        }

        // delete customer

        private void del_custo_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerid_display.Text != "")
                {
                    databaseFields.CustomerId = Convert.ToInt32(customerid_display.Text);
                    string qry = "Delete from Customers where CustomerId=" + databaseFields.CustomerId + "";
                    databaseInteractions.Operations(qry);
                    address_of_customer.Text = "";
                    email_id_customer.Text = "";
                    full_name_customer.Text = "";
                    mobile_of_customer.Text = "";
                    display_message.Text = "Customer is deleted duccessfully";
                }
            }
            catch (Exception)
            {
                display_message.Text = "Invalid Customer Please check";
            }
        }

        // adding Video to database
        private void Add_book_Click(object sender, EventArgs e)
        {
            try
            {
                if (title_Book.Text != "" && ratting_book.Text != "" && year_realsed.Text != "" && copies_of_book.Text != "" && bookCost != "" && author_text_box.Text != "" && publisher.Text != "")
                {
                    databaseFields.Title = title_Book.Text;
                    databaseFields.Ratting = ratting_book.Text;
                    databaseFields.Year = year_realsed.Text;
                    databaseFields.Copies = copies_of_book.Text;
                    databaseFields.Cost = bookCost;
                    databaseFields.Author = author_text_box.Text;
                    databaseFields.Publisher = publisher.Text;

                    string qry = "Insert into Books(Title,Ratting,Year,Copies,Plot,Genre,Cost)values('" + databaseFields.Title + "','" + databaseFields.Ratting + "'," + databaseFields.Year + "," + databaseFields.Copies + ",'" + databaseFields.Author + "','" + databaseFields.Publisher + "','" + databaseFields.Cost + "')";
                    databaseInteractions.Operations(qry);
                    display_bookingID.Text = "";
                    title_Book.Text = "";
                    ratting_book.Text = "";
                    year_realsed.Text = "";
                    copies_of_book.Text = "";
                    author_text_box.Text = "";
                    publisher.Text = "";
                    display_message.Text = "Your book is added Successfully";
                }
                else
                {
                    display_message.Text = "Please check all fields are mandatory";
                }

            }
            catch (Exception ex)
            {
                display_message.Text = "Please check all fields are mandatory";
            }

        }

        // update video to database
        private void update_book_Click(object sender, EventArgs e)
        {
            try
            {
                if (display_bookingID.Text != "" && title_Book.Text != "" && ratting_book.Text != "" && year_realsed.Text != "" && copies_of_book.Text != "" && bookCost != "" && author_text_box.Text != "" && publisher.Text != "")
                {

                    databaseFields.BookId = Convert.ToInt32(display_bookingID.Text);
                    databaseFields.Title = title_Book.Text;
                    databaseFields.Ratting = ratting_book.Text;
                    databaseFields.Year = year_realsed.Text;
                    databaseFields.Copies = copies_of_book.Text;
                    databaseFields.Cost = bookCost;
                    databaseFields.Author = author_text_box.Text;
                    databaseFields.Publisher = publisher.Text;


                    string qry = "update Books set Title='" + databaseFields.Title + "',Ratting='" + databaseFields.Ratting + "',Year=" + databaseFields.Year + ",Cost=" + databaseFields.Cost + ",Copies=" + databaseFields.Copies + ",Plot='" + databaseFields.Author + "',Genre='" + databaseFields.Publisher + "' where BookId=" + databaseFields.BookId + "";
                    databaseInteractions.Operations(qry);
                    display_bookingID.Text = "";
                    title_Book.Text = "";
                    ratting_book.Text = "";
                    year_realsed.Text = "";
                    copies_of_book.Text = "";
                    author_text_box.Text = "";
                    publisher.Text = "";
                    display_message.Text = "Your book is updated succesfuly";
                }
                else
                {
                    display_message.Text = "Please check all fields are mandatory";
                }

            }
            catch (Exception ex)
            {
                display_message.Text = "Please check all fields are mandatory";
            }

        }

        private void del_book_Click(object sender, EventArgs e)
        {
            try
            {
                if (display_bookingID.Text != "")
                {

                    databaseFields.BookId = Convert.ToInt32(display_bookingID.Text);

                    string qry = "Delete from Books where BookId=" + databaseFields.BookId + "";
                    databaseInteractions.Operations(qry);
                    display_bookingID.Text = "";
                    title_Book.Text = "";
                    year_realsed.Text = "";
                    ratting_book.Text = "";
                    copies_of_book.Text = "";
                    author_text_box.Text = "";
                    publisher.Text = "";
                    display_message.Text = "your book is deleted successfully";
                }
                else
                {
                    display_message.Text = "Invalid book";
                }

            }
            catch (Exception ex)
            {
                display_message.Text = "Invalid book";
            }



        }

        // issue on rent

        private void issue_rental_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerid_display.Text != "" && display_bookingID.Text != "")
                {
                    databaseFields.CustomerId = Convert.ToInt32(customerid_display.Text);
                    databaseFields.BookId = Convert.ToInt32(display_bookingID.Text);
                    databaseFields.IssueDate = dateTimePicker1.Text;
                    databaseFields.ReturnDate = "Booked";

                    string qry = "Insert into Rentals(BookId,CustomerId,IssueDate,ReturnDate)values(" + databaseFields.BookId + "," + databaseFields.CustomerId + ",'" + databaseFields.IssueDate + "','" + databaseFields.ReturnDate + "')";
                    databaseInteractions.Operations(qry);

                    display_bookingID.Text = "";
                    title_Book.Text = "";
                    ratting_book.Text = "";
                    year_realsed.Text = "";
                    copies_of_book.Text = "";
                    author_text_box.Text = "";
                    publisher.Text = "";
                    full_name_customer.Text = "";
                    address_of_customer.Text = "";
                    email_id_customer.Text = "";
                    customerid_display.Text = "";
                    mobile_of_customer.Text = "";
                    display_message.Text = "Your book is booked ";
                }
                else
                {
                    display_message.Text = "Please check all fields are mandatory";
                }

            }
            catch (Exception)
            {
                display_message.Text = "Please check all fields are mandatory";
            }


        }

        // return a rental video

        private void return_book_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (databaseFields.BookId > 0 && customerid_display.Text != "" && display_bookingID.Text != "")
                {
                    databaseFields.CustomerId = Convert.ToInt32(customerid_display.Text);
                    databaseFields.BookId = Convert.ToInt32(display_bookingID.Text);
                    databaseFields.IssueDate = dateTimePicker1.Text;
                    databaseFields.ReturnDate = dateTimePicker2.Text;

                    string qry = "Update  Rentals set CustomerId=" + databaseFields.CustomerId + ",BookId=" + databaseFields.BookId + ",IssueDate='" + databaseFields.IssueDate + "',ReturnDate='" + databaseFields.ReturnDate + "' where BookId=" + databaseFields.BookId + "";
                    databaseInteractions.Operations(qry);

                    DateTime nw = DateTime.Now;

                    DateTime old = Convert.ToDateTime(dateTimePicker1.Text);

                    string diff = (nw - old).TotalDays.ToString();

                    Double DaysInterval = Math.Round(Convert.ToDouble(diff));

                    DataTable dataTable = new DataTable();
                    dataTable = databaseInteractions.DatabaseOperations("Select * from Books where BookId=" + Convert.ToInt32(display_bookingID.Text) + "");
                    int cost = Convert.ToInt32(dataTable.Rows[0]["Cost"].ToString());

                    display_bookingID.Text = "";
                    title_Book.Text = "";
                    ratting_book.Text = "";
                    year_realsed.Text = "";
                    copies_of_book.Text = "";
                    author_text_box.Text = "";
                    publisher.Text = "";

                    full_name_customer.Text = "";
                    address_of_customer.Text = "";
                    email_id_customer.Text = "";
                    customerid_display.Text = "";
                    mobile_of_customer.Text = "";
                    display_message.Text = "Thank you, Your book is returned and your generated bill is $" + (DaysInterval * cost);
                }
                else
                {
                    display_message.Text = "Please check all fields are mandatory";
                }
            }
            catch (Exception ex)
            {
                display_message.Text = "Please check all fields are mandatory";
            }



        }

        // detele from rental table

        private void delete_book_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (databaseFields.BookId > 0)
                {
                    string qry = "Delete from Rentals where BookId=" + databaseFields.BookId + " And CustomerId=" + databaseFields.CustomerId + "";
                    databaseInteractions.Operations(qry);
                    display_bookingID.Text = "";
                    title_Book.Text = "";
                    ratting_book.Text = "";
                    year_realsed.Text = "";
                    copies_of_book.Text = "";
                    author_text_box.Text = "";
                    publisher.Text = "";

                    full_name_customer.Text = "";
                    address_of_customer.Text = "";
                    email_id_customer.Text = "";
                    customerid_display.Text = "";
                    mobile_of_customer.Text = "";
                    display_message.Text = "your book is deleted  successfully that was booked by you";
                }
                else
                {
                    display_message.Text = "Invalid book";
                }

            }
            catch (Exception)
            {
                display_message.Text = "Invalid book";
            }



        }

        // show videos

        private void showBook_stored_Click(object sender, EventArgs e)
        {
            databaseFields.Option = 3;
            DataTable dataTable = new DataTable();
            dataTable = databaseInteractions.DatabaseOperations("Select * from Books");
            dataGridView1.DataSource = dataTable;

        }
        // show customers

        private void Showing_customer_Click(object sender, EventArgs e)
        {

            databaseFields.Option = 1;
            DataTable dataTable = new DataTable();
            dataTable = databaseInteractions.DatabaseOperations("Select * from Customers");
            dataGridView1.DataSource = dataTable;
        }

        // show rentals

        private void show_rental_Click(object sender, EventArgs e)
        {
            databaseFields.Option = 2;
            DataTable dataTable = new DataTable();
            dataTable = databaseInteractions.DatabaseOperations("select * from Rentals");
            dataGridView1.DataSource = dataTable;

        }

        // show regular customers

        private void btn_regular_customer_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();

            dataTable = databaseInteractions.DatabaseOperations("Select * from Customers");

            int x = 0;
            int count = 0;
            string Title = "";

            while (x < dataTable.Rows.Count)
            {
                DataTable dataTablelRental = new DataTable();

                dataTablelRental = databaseInteractions.DatabaseOperations("Select * from Rentals where CustomerId=" + Convert.ToInt32(dataTable.Rows[x]["CustomerId"]) + "");


                if (dataTablelRental.Rows.Count > count)
                {

                    Title = dataTable.Rows[x]["Name"].ToString();
                    count = dataTablelRental.Rows.Count;
                }
                x++;
            }
            display_message.Text = "Grand book store's regular customer is" + Title;

        }

        // show trending video

        private void trending_book_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = databaseInteractions.DatabaseOperations("select * from Books");

            int x = 0;
            string Title = "";
            int count = 0;
            while (x < dataTable.Rows.Count)
            {
                DataTable Rental = new DataTable();

                Rental = databaseInteractions.DatabaseOperations("select * from Rentals where BookId=" + Convert.ToInt32(dataTable.Rows[x]["BookId"]) + "");


                if (Rental.Rows.Count > count)
                {

                    Title = dataTable.Rows[x]["title"].ToString();
                    count = Rental.Rows.Count;

                }
                x++;
            }
            display_message.Text = "Grand book store's trending book is" + Title;

        }

        private void year_realsed_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int releasedYear = Convert.ToInt32(year_realsed.Text.ToString());
                DateTime dateTime = DateTime.Now;

                int currentYear = dateTime.Year;

                if ((currentYear - releasedYear) > 5)
                {
                    bookCost = "2";
                }
                else
                {
                    bookCost = "5";
                }
            }
            catch (Exception)
            {
            }

        }

        // grid view click system

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (databaseFields.Option)
            {
                case 1:

                    customerid_display.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    full_name_customer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    email_id_customer.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    mobile_of_customer.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    address_of_customer.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    break;

                case 2:
                    databaseFields.BookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    databaseFields.CustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    customerid_display.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    display_bookingID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    
                    
                    break;

                case 3:
                    display_bookingID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    title_Book.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    ratting_book.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    year_realsed.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    copies_of_book.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    author_text_box.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    publisher.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    databaseFields.Cost = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    break;
            }
            databaseFields.Option = 0;

        }
    }
}

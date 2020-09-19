import { Component, OnInit } from '@angular/core';
import { PhonebookContactService } from 'src/app/shared/phonebook-contact.service';
import { formArrayNameProvider } from '@angular/forms/src/directives/reactive_directives/form_group_name';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-phonebook-contact',
  templateUrl: './phonebook-contact.component.html',
  styles: []
})
export class PhonebookContactComponent implements OnInit {

  constructor(public service: PhonebookContactService, private toaster: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  onSubmit(form?: NgForm) {
    if (this.service.formData.ContactID == 0) {
        this.insertContact(form);
    } else {
      this.updateContact(form);
    }
  }

  insertContact(form?: NgForm){
    this.service.postPhoneBookContact().subscribe(
      res => {
        this.resetForm(form);
        this.toaster.success('Contact Created Successfully' , 'PhoneBook');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }

    updateContact(form ?: NgForm){
      this.service.updatePhoneBookContact().subscribe(
        res => {
          this.resetForm(form);
          this.toaster.info('Contact Updated Successfully' , 'PhoneBook');
          this.service.refreshList();
        },
        err => {
          console.log(err);
        }
      );
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
    }
    this.service.formData = {
      ContactID: 0,
      FirstName: '',
      PhoneNumber: '',
      LastName: '',
      EmailAddress: ''
    };
  }

}


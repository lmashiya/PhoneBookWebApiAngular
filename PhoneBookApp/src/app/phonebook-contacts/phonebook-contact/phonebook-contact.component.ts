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
    this.service.postPhoneBookContact(form.value).subscribe(
      res => {
        this.resetForm(form);
        this.toaster.success('Submitted Successfully' , 'PhoneBook');
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

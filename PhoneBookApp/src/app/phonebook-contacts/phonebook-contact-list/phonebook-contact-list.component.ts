import { Component, OnInit } from '@angular/core';
import { PhonebookContactService } from 'src/app/shared/phonebook-contact.service';
import { PhonebookContact } from 'src/app/shared/phonebook-contact.model';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-phonebook-contact-list',
  templateUrl: './phonebook-contact-list.component.html',
  styles: []
})
export class PhonebookContactListComponent implements OnInit {

  constructor(private service: PhonebookContactService , private toaster: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: PhonebookContact) {
    this.service.formData = Object.assign({}, pd);
  }

  onDelete(contactID) {
    if (confirm('Delete Contact ?')) {
    this.service.deletePhoneBookContact(contactID).subscribe(
      res => {
        this.service.refreshList();
        this.toaster.warning('Contact Deleted Successfully', 'Phonebook');
      },
      err => {
        console.log(err);
      });
  }
}
}

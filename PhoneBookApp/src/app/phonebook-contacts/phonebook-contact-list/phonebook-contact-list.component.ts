import { Component, OnInit } from '@angular/core';
import { PhonebookContactService } from 'src/app/shared/phonebook-contact.service';
import { PhonebookContact } from 'src/app/shared/phonebook-contact.model';

@Component({
  selector: 'app-phonebook-contact-list',
  templateUrl: './phonebook-contact-list.component.html',
  styles: []
})
export class PhonebookContactListComponent implements OnInit {

  constructor(private service: PhonebookContactService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: PhonebookContact){
    this.service.formData = Object.assign({}, pd);
  }
}

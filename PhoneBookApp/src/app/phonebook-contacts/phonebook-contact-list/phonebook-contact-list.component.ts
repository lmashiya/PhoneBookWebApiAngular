import { Component, OnInit } from '@angular/core';
import { PhonebookContactService } from 'src/app/shared/phonebook-contact.service';

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

}

import { Component, OnInit } from '@angular/core';
import { PhonebookContactService } from 'src/app/shared/phonebook-contact.service';

@Component({
  selector: 'app-phonebook-contact',
  templateUrl: './phonebook-contact.component.html',
  styles: []
})
export class PhonebookContactComponent implements OnInit {

  constructor(private service: PhonebookContactService) { }

  ngOnInit() {
  }

}

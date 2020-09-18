import { Component, OnInit } from '@angular/core';
import { PhoneBookContactService } from 'src/app/shared/phone-book-contact.service';

@Component({
  selector: 'app-phone-book-contact',
  templateUrl: './phone-book-contact.component.html',
  styles: [
  ]
})
export class PhoneBookContactComponent implements OnInit {

  constructor(private service: PhoneBookContactService ) { }

  ngOnInit(): void {
  }

}

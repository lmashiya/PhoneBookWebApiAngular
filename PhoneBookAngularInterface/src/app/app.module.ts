import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { PhoneBookContactsComponent } from './phone-book-contacts/phone-book-contacts.component';
import { PhoneBookContactListComponent } from './phone-book-contacts/phone-book-contact-list/phone-book-contact-list.component';
import { PhoneBookContactComponent } from './phone-book-contacts/phone-book-contact/phone-book-contact.component';
import {PhoneBookContactService} from './shared/phone-book-contact.service';


@NgModule({
  declarations: [
    AppComponent,
    PhoneBookContactsComponent,
    PhoneBookContactListComponent,
    PhoneBookContactComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
  ],
  providers: [PhoneBookContactService],
  bootstrap: [AppComponent]
})
export class AppModule { }

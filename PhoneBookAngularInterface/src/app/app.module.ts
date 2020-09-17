import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PhoneBookContactsComponent } from './phone-book-contacts/phone-book-contacts.component';
import { PhoneBookContactComponent } from './PhoneBook-Contacts/phone-book-contact/phone-book-contact.component';
import { PhoneBookContactListComponent } from './phone-book-contacts/phone-book-contact-list/phone-book-contact-list.component';

@NgModule({
  declarations: [
    AppComponent,
    PhoneBookContactsComponent,
    PhoneBookContactComponent,
    PhoneBookContactListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

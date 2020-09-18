import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { PhonebookContactsComponent } from './phonebook-contacts/phonebook-contacts.component';
import { PhonebookContactComponent } from './phonebook-contacts/phonebook-contact/phonebook-contact.component';
import { PhonebookContactListComponent } from './phonebook-contacts/phonebook-contact-list/phonebook-contact-list.component';
import { PhonebookContactService } from './shared/phonebook-contact.service';
import { HttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    PhonebookContactsComponent,
    PhonebookContactComponent,
    PhonebookContactListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClient
  ],
  providers: [PhonebookContactService],
  bootstrap: [AppComponent]
})
export class AppModule { }

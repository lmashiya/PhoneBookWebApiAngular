import { Injectable } from '@angular/core';
import { PhonebookContact } from './phonebook-contact.model';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PhonebookContactService {
  formData: PhonebookContact = new PhonebookContact();
  readonly rootURL = 'http://localhost:5000/api';

  constructor(private http: HttpClient) { }

  postPhoneBookContact(formData: PhonebookContact){
    return this.http.post(this.rootURL + '/PhoneBookContact', formData);
  }
}

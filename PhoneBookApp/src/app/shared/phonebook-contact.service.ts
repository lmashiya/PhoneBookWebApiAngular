import { Injectable } from '@angular/core';
import { PhonebookContact } from './phonebook-contact.model';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PhonebookContactService {
  formData: PhonebookContact;
  readonly rootURL = 'http://localhost:5000/api';
  list: PhonebookContact[];

  constructor(private http: HttpClient) { }

  postPhoneBookContact() {
    return this.http.post(this.rootURL + '/PhoneBookContact', this.formData);
  }
  refreshList() {
    this.http.get(this.rootURL + '/PhoneBookContact').toPromise()
    .then( res => this.list = res as PhonebookContact[]);
  }

  updatePhoneBookContact() {
    return this.http.put(this.rootURL + '/PhoneBookContact/' + this.formData.ContactID, this.formData);
  }

  deletePhoneBookContact() {
    return this.http.put(this.rootURL + '/PhoneBookContact/' + this.formData.ContactID, this.formData);
  }
}

import { Injectable } from '@angular/core';
import { PhonebookContact } from './phonebook-contact.model';

@Injectable({
  providedIn: 'root'
})
export class PhonebookContactService {
  formData: PhonebookContact;
  constructor() { }
}

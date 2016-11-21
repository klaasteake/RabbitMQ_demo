import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, ReactiveFormsModule } from '@angular/forms';

import { IUser } from '../user/user.interface';
import { UserContext } from '../user/user.context';

@Component({
  moduleId: module.id,
  selector: 'sd-home',
  styleUrls: ['home.component.css'],
  templateUrl: 'home.component.html',
})

export class HomeComponent implements OnInit {

  registerForm: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      firstName: 'Pietje',
      surname: 'Puk', 
      emailAddress: 'pietjepuk@gmail.com'
    });
  }

  users: UserContext[] = [
    UserContext.CreateDummy("Pietje", "Puk", "pietjepuk@gmail.com"),
    UserContext.CreateDummy("Guus", "Flater", "guusFlater@gmail.com")
    ];

  register(model: IUser, isValid: boolean) {
        // check if model is valid
        // if valid, call API to save customer
        console.log(model, isValid);
        this.users.push(new UserContext(model));
    }

}
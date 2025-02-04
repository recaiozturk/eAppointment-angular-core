import { Component, ElementRef, ViewChild } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { LoginModel } from '../../models/login.model';
import { FormValidateDirective } from 'form-validate-angular';
import { HttpService } from '../../services/http.service';
import { Router } from '@angular/router';
import { LoginResponseModel } from '../../models/login-response.model';

@Component({
  selector: 'app-login',
  imports: [FormsModule,FormValidateDirective],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  //login modelimizs
  login:LoginModel= new LoginModel();

  //password input tanimliyoruz
  @ViewChild("password") password : ElementRef<HTMLInputElement> | undefined;

  constructor
  (
    private http: HttpService,
    private router: Router
  ) {  
  }

  showOrHidePassword(){
    if(this.password === undefined) return;
    
    if(this.password.nativeElement.type === "password"){
      this.password.nativeElement.type = "text";
    }else{
      this.password.nativeElement.type = "password";
    }
  }

  signIn(form:NgForm){
    if(form.valid){
      this.http.post<LoginResponseModel>("Auth/Login",this.login,(res)=> {
        localStorage.setItem("token", res.data!.token);
        this.router.navigateByUrl("/");
      })
    }
  }

}

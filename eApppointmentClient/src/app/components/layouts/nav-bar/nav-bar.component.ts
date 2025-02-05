import { Component } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AuthService } from '../../../services/auth.service';

@Component({
  selector: 'app-nav-bar',
  imports: [RouterLink],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css'
})
export class NavBarComponent {

  constructor(
    private router: Router,
    public auth: AuthService
  ){}

  signOut(){
    localStorage.removeItem("token");
    this.router.navigateByUrl("/login");
  }

}

import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'sign-in-page',
  templateUrl: './sign-in-page.component.html',
  styleUrl: './sign-in-page.component.scss'
})
export class SignInPageComponent {
  constructor(private titleService: TitleService, private router: Router) {
    this.titleService.setTitle('Sign In');
  }

  onComplete(redirectionPath: string) {
    this.router.navigate([redirectionPath]);
  }
}

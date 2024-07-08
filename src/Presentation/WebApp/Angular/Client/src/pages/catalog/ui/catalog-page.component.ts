import { Component } from '@angular/core';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'catalog-page',
  templateUrl: './catalog-page.component.html',
  styleUrl: './catalog-page.component.scss'
})
export class CatalogPageComponent {
  constructor(private titleService: TitleService) {
    this.titleService.setTitle('Catalog');
  }
}

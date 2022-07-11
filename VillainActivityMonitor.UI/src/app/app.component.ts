import { Component } from '@angular/core';
import { Villain } from './models/villain';
import { VillainService } from './services/villain.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'VillainActivityMonitor.UI';
  villains: Villain[] = [];

  constructor(private villainService: VillainService) { }

  ngOnInit(): void {
    this.villainService.getVillains().subscribe((result: Villain[]) => (this.villains = result));
    console.log(this.villains);
  }
}

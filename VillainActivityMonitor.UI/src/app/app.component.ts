import { Component, SimpleChanges } from '@angular/core';
import { Villain } from './models/villain';
import { VillainService } from './services/villain.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title: string = 'VillainActivityMonitor.UI';
  villains: Villain[] = [];
  public newVillain: Villain = new Villain();

  constructor(private villainService: VillainService) { }

  ngOnInit(): void {
    this.villainService.getVillains().subscribe((result: Villain[]) => (this.villains = result));
  }

  public AddVillain(): void {
    this.newVillain.name = `${this.newVillain.firstName} ${this.newVillain.lastName}`;
    this.villainService.addVillain(this.newVillain);
  }
}

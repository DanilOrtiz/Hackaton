import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SprintFrmComponent } from './sprint-frm.component';

describe('SprintFrmComponent', () => {
  let component: SprintFrmComponent;
  let fixture: ComponentFixture<SprintFrmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SprintFrmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SprintFrmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { FighterService } from './fighter.service';

describe('FighterService', () => {
  let service: FighterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FighterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

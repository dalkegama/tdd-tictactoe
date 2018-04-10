import { IGameState } from './IGameState';
import './Player';

export interface IGamePlay {
    Play(x: number, y:number, player:Player): void;

    State(): IGameState;
}
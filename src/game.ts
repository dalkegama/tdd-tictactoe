import { IGamePlay } from './contracts/IGamePlay';
import { IGameState } from './contracts/IGameState';
import './contracts/Player';

export class Game implements IGamePlay, IGameState {
    board?: Player[][];
    winner?: Player;
    isDraw: boolean;

    Play(x: number, y: number, player: Player): void {
        throw new Error("Method not implemented.");
    }

    State(): IGameState {
        throw new Error("Method not implemented.");
    }
}

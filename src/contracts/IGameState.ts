import './Player';

export interface IGameState {
    board?: Player[][];
    winner?: Player;
    isDraw: boolean;
}
import React from "react";
import { Draggable } from "react-beautiful-dnd";

const Block = ({ block, index }) => {
  return (
    <Draggable draggableId={`id-${block.id}`} index={index}>
      {(provided) => (
        <div
          {...provided.draggableProps}
          {...provided.dragHandleProps}
          ref={provided.innerRef}
        >
          {block.content}
        </div>
      )}
    </Draggable>
  );
};

export default Block;

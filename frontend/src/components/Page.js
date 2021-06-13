import React, { useState, useEffect, useRef } from "react";
import axios from "axios";
import { DragDropContext, Droppable } from "react-beautiful-dnd";
import Block from "./Block";

const Page = ({ pageId }) => {
  const url = "/api/pages";
  const [page, setPage] = useState();

  useEffect(() => {
    axios
      .get(`${url}/${pageId}`)
      .then((res) => setPage(res.data))
      .catch((err) => console.log(err));
  }, []);

  const reorder = (list, startIndex, endIndex) => {
    const result = Array.from(list);
    const [removed] = result.splice(startIndex, 1);
    result.splice(endIndex, 0, removed);

    return result;
  };

  const onDragEnd = (result) => {
    // rerender the drop area and preserve order
    const { source, destination, draggableId } = result;

    // check if smthn was draggaed
    if (!destination) {
      return;
    }
    // check if the dragggable was moved somewhere other than its original place
    if (
      destination.droppableId === source.droppableId &&
      destination.index === source.index
    ) {
      return;
    }

    let newBlocks = reorder(page.blocks, source.index, destination.index);
    let newPage = { ...page, blocks: newBlocks };

    setPage(newPage);
  };

  const postPage = () => {
    axios
      .post(url, page)
      .then((res) => res.data)
      .catch((err) => console.log(err));
  };
  return (
    <div>
      {page ? (
        <DragDropContext onDragEnd={onDragEnd}>
          <h1>page title </h1>
          <Droppable droppableId="blocks">
            {(provided) => (
              <div ref={provided.innerRef} {...provided.droppableProps}>
                {page.blocks.map((block, index) => (
                  <Block key={block.id} block={block} index={index} />
                ))}
                {provided.placeholder}
              </div>
            )}
          </Droppable>
        </DragDropContext>
      ) : null}

      <button
        class="px-4 py-2 rounded text-white shadow-lg bg-blue-500 hover:bg-blue-600 focus:bg-blue-700"
        onClick={() => postPage()}
      >
        Save Page
      </button>
    </div>
  );
};

export default Page;

import React from 'react'
import { Container, Row, Col } from 'react-bootstrap'

export default function NotFoundScreen() {
  return (
    <Container fluid>
      <Row className="pt-5 text-center">
        <Col />
        <Col sm="4" className="pt-5">
          <img
            src="https://i.pinimg.com/originals/6d/a8/78/6da878cf7299317b2bd88c7471111626.gif"
            alt="404"
          />
        </Col>
        <Col />
      </Row>
    </Container>
  )
}
